using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LoliconGUISharp
{
    public partial class MainForm : Form, QueryListener
    {
        private const string TAG = nameof(MainForm);
#if DEBUG
        private bool r18 = true;
#else
        private bool r18 = false;
#endif
        private const int MAX_PAGE = 1;
        private SetuRequest[] histories = new SetuRequest[MAX_PAGE];
        private SetuRequest cache;
        private int page;
        private int index;
        private int SETU_PER_REQUEST = 10;
        private bool SIZE_1200 = true;
        private const string SAVE_FOLDER = "saved";
        private bool AutoPlay;

        public MainForm()
        {
            SecretUtil.GetAndSetLoliconApiKey();
            InitializeComponent();
            SetControlsEnabled(false);
            CheckBoxR18.Checked = r18;
#if DEBUG
            CheckBoxR18.Visible = true;
#endif
            Query();
        }

        private void Query()
        {
            new Thread(TaskQuery).Start();
        }

        private void TaskQuery()
        {
            OnQueryStart();
            if (histories[page]?.data?.Count < 1) histories[page] = null;
            if (histories[page] == null)
            {
                if (cache == null)
                {
                    Log.D(TAG, $"PAGE={page} no cache");
                    histories[page] = QuerySetu();
                }
                else
                {
                    Log.D(TAG, $"PAGE={page} use cache");
                    histories[page] = cache;
                    cache = null;
                }
            }

            for (var i = 0; i < histories[page]?.data?.Count; i++) new Thread(TaskQuerySetu).Start(i);
        }

        private void TaskQuerySetu(object Arg)
        {
            var i = (int) Arg;
            Log.D(TAG, $"PAGE={page} INDEX={index} I={i} query image");
            if (histories[page] != null) histories[page]?.data?[i]?.QueryImage();
            if (i == index) BeginInvoke(new OnQueryFinishDelegate(OnQueryFinish));
        }

        private void TaskQueryCacheSetu(object Arg)
        {
            var i = (int) Arg;
            Log.D(TAG, $"PAGE=CACHE I={i} query image");
            if (cache != null) cache?.data?[i]?.QueryImage();
        }

        private SetuRequest QuerySetu()
        {
            SetuRequest result = null;
            do
            {
                try
                {
                    result = LoliconApi.QuerySetu(r18 ? LoliconApi.R18_ONLY : LoliconApi.NON_R18, num: SETU_PER_REQUEST,
                        size1200: SIZE_1200);
                }
                catch (ArgumentNullException)
                {
                }
            } while (result == null);
            switch (result?.code)
            {
                case LoliconApi.INTERNAL_ERROR:
                    MessageBox.Show("遇到 Lolicon API 内部错误，请稍后尝试重载。", "警告");
                    break;
                case LoliconApi.API_KEY_INVALID:
                    MessageBox.Show("Lolicon API 反馈密匙无效，请稍后尝试自定义密匙。", "警告");
                    break;
                case LoliconApi.BANED:
                    MessageBox.Show("Lolicon API 拒绝了我们的请求，请稍后尝试自定义密匙。", "警告");
                    break;
                case LoliconApi.REACHED_LIMIT:
                    MessageBox.Show($"该密匙剩余请求额度为 {result?.quota} ，请稍后尝试自定义密匙。" +
                        $"\n或者等待 {result?.quota_min_ttl / 60 / 60} 小时 {result?.quota_min_ttl / 60 % 60}" +
                        $" 分 {result?.quota_min_ttl % 60 % 60} 秒。", "警告");
                    break;
            }
            return result;
        }

        private void SetControlsEnabled(bool value)
        {
            ButtonInformation.Enabled = value;
            ButtonSave.Enabled = value;
            ButtonPrevious.Enabled = value;
            ButtonNext.Enabled = value;
            CheckBoxR18.Enabled = value;
            TextBoxAutoplayDelay.Enabled = value;
            ButtonAutoplay.Enabled = value;
            if (value)
            {
                if (page - 1 < 0 && index - 1 < 0) ButtonPrevious.Enabled = false;
                if (AutoPlay) TextBoxAutoplayDelay.Enabled = false;
            }
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            SetControlsEnabled(false);
            if (index - 1 < 0)
            {
                if (page - 1 < 0)
                {
                    SetControlsEnabled(true);
                    return;
                }

                index = (int) histories[page - 1]?.data?.Count - 1;
                page--;
            }
            else
            {
                index--;
            }

            Query();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            SetControlsEnabled(false);
            if (index + 1 > histories[page]?.data?.Count - 1)
            {
                index = 0;
                if (page + 1 > MAX_PAGE - 1)
                {
                    var tmp = histories.ToList();
                    tmp.RemoveAt(0);
                    tmp.Add(null);
                    histories = tmp.ToArray();
                }
                else
                {
                    page++;
                }
            }
            else
            {
                index++;
            }

            Query();
        }

        private void CheckBoxR18_CheckedChanged(object sender, EventArgs e)
        {
            r18 = CheckBoxR18.Checked;
        }

        public void OnQueryStart()
        {
            Log.D(TAG, "OnQueryStart");
        }

        public void OnQueryFinish()
        {
            Log.D(TAG, "OnQueryFinish");
            if (histories[page]?.data?[index]?.image == null) Log.E(TAG, "image==null");
            PictureBoxSetu.Image = histories[page]?.data?[index]?.image;
            SetControlsEnabled(true);
            Log.D(TAG, "query cache");
            cache = QuerySetu();
            for (var i = 0; i < cache?.data?.Count; i++) new Thread(TaskQueryCacheSetu).Start(i);
        }

        public delegate void OnQueryFinishDelegate();

        private void ButtonInformation_Click(object sender, EventArgs e)
        {
            new InformationForm(histories[page]?.data?[index]).ShowDialog();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var setu = histories?[page]?.data?[index];
            if (!Directory.Exists(SAVE_FOLDER)) Directory.CreateDirectory(SAVE_FOLDER);
            var filePath = $"{SAVE_FOLDER}\\{setu?.pid}-{setu.title}.png";
            if (!File.Exists(filePath)) setu?.image?.Save(filePath);
        }

        private void ButtonAutoplay_Click(object sender, EventArgs e)
        {
            AutoPlay = !AutoPlay;
            SetControlsEnabled(true);
            if (AutoPlay) ButtonAutoplay.Text = "Stop";
            else ButtonAutoplay.Text = "自动播放";
            TimerAutoplay.Enabled = AutoPlay;
        }

        private void TimerAutoplay_Tick(object sender, EventArgs e)
        {
            ButtonNext.PerformClick();
        }

        private void TextBoxAutoplayDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var s = int.Parse(TextBoxAutoplayDelay.Text);
                if (s <= 0 || s > 60) TextBoxAutoplayDelay.Text = (TimerAutoplay.Interval / 1000).ToString();
                else TimerAutoplay.Interval = int.Parse(TextBoxAutoplayDelay.Text) * 1000;
            }
            catch (FormatException)
            {
                TextBoxAutoplayDelay.Text = (TimerAutoplay.Interval / 1000).ToString();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
#if DEBUG
            MessageBox.Show(
                $"{Application.ProductName} V{Application.ProductVersion} Debug\n制作 By FatFish\n作者QQ:1171188146",
                "About");
#else
            MessageBox.Show(
                $"{Application.ProductName} V{Application.ProductVersion}\n制作 By FatFish\n作者QQ:1171188146",
                "About");
#endif
        }

        private void customSetuCountPerRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var s = int.Parse(Interaction.InputBox("Please enter a 1-10 int:", "自定义 单个请求的色图数"));
                if (s > 0 && s <= 10) SETU_PER_REQUEST = s;
            }
            catch (FormatException)
            {
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void LoadSize1200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSize1200ToolStripMenuItem.Checked = !LoadSize1200ToolStripMenuItem.Checked;
            SIZE_1200 = LoadSize1200ToolStripMenuItem.Checked;
        }

        private void customLoliconAPIkeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = Interaction.InputBox("Please enter Lolicon API key string:", "自定义 Lolicon API 密匙");
            if(!(string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))) LoliconApi.SetApiKey(s);
        }
    }
}