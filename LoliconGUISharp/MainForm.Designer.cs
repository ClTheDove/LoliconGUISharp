namespace LoliconGUISharp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBoxSetu = new System.Windows.Forms.PictureBox();
            this.ButtonPrevious = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonInformation = new System.Windows.Forms.Button();
            this.ButtonAutoplay = new System.Windows.Forms.Button();
            this.TextBoxAutoplayDelay = new System.Windows.Forms.TextBox();
            this.LabelAutoplay = new System.Windows.Forms.Label();
            this.CheckBoxR18 = new System.Windows.Forms.CheckBox();
            this.TimerAutoplay = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customSetuCountPerRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customMaximumHistoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customLoliconAPIkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadSize1200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSetu)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxSetu
            // 
            this.PictureBoxSetu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxSetu.BackColor = System.Drawing.Color.White;
            this.PictureBoxSetu.Location = new System.Drawing.Point(12, 10);
            this.PictureBoxSetu.Name = "PictureBoxSetu";
            this.PictureBoxSetu.Size = new System.Drawing.Size(864, 508);
            this.PictureBoxSetu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSetu.TabIndex = 0;
            this.PictureBoxSetu.TabStop = false;
            // 
            // ButtonPrevious
            // 
            this.ButtonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPrevious.AutoSize = true;
            this.ButtonPrevious.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonPrevious.Location = new System.Drawing.Point(194, 526);
            this.ButtonPrevious.Name = "ButtonPrevious";
            this.ButtonPrevious.Size = new System.Drawing.Size(94, 35);
            this.ButtonPrevious.TabIndex = 1;
            this.ButtonPrevious.Text = "Previous";
            this.ButtonPrevious.UseVisualStyleBackColor = true;
            this.ButtonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonNext.AutoSize = true;
            this.ButtonNext.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonNext.Location = new System.Drawing.Point(294, 526);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(79, 35);
            this.ButtonNext.TabIndex = 2;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSave.AutoSize = true;
            this.ButtonSave.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSave.Location = new System.Drawing.Point(102, 526);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(86, 35);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "保存";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonInformation
            // 
            this.ButtonInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonInformation.AutoSize = true;
            this.ButtonInformation.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonInformation.Location = new System.Drawing.Point(10, 526);
            this.ButtonInformation.Name = "ButtonInformation";
            this.ButtonInformation.Size = new System.Drawing.Size(86, 35);
            this.ButtonInformation.TabIndex = 4;
            this.ButtonInformation.Text = "信息";
            this.ButtonInformation.UseVisualStyleBackColor = true;
            this.ButtonInformation.Click += new System.EventHandler(this.ButtonInformation_Click);
            // 
            // ButtonAutoplay
            // 
            this.ButtonAutoplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAutoplay.AutoSize = true;
            this.ButtonAutoplay.Font = new System.Drawing.Font("微软雅黑 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAutoplay.Location = new System.Drawing.Point(779, 526);
            this.ButtonAutoplay.Name = "ButtonAutoplay";
            this.ButtonAutoplay.Size = new System.Drawing.Size(99, 35);
            this.ButtonAutoplay.TabIndex = 6;
            this.ButtonAutoplay.Text = "自动播放";
            this.ButtonAutoplay.UseVisualStyleBackColor = true;
            this.ButtonAutoplay.Click += new System.EventHandler(this.ButtonAutoplay_Click);
            // 
            // TextBoxAutoplayDelay
            // 
            this.TextBoxAutoplayDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAutoplayDelay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxAutoplayDelay.Location = new System.Drawing.Point(608, 540);
            this.TextBoxAutoplayDelay.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxAutoplayDelay.MaxLength = 2;
            this.TextBoxAutoplayDelay.Name = "TextBoxAutoplayDelay";
            this.TextBoxAutoplayDelay.Size = new System.Drawing.Size(40, 29);
            this.TextBoxAutoplayDelay.TabIndex = 8;
            this.TextBoxAutoplayDelay.Text = "30";
            this.TextBoxAutoplayDelay.TextChanged += new System.EventHandler(this.TextBoxAutoplayDelay_TextChanged);
            // 
            // LabelAutoplay
            // 
            this.LabelAutoplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelAutoplay.AutoSize = true;
            this.LabelAutoplay.BackColor = System.Drawing.Color.Transparent;
            this.LabelAutoplay.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelAutoplay.Location = new System.Drawing.Point(604, 519);
            this.LabelAutoplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAutoplay.Name = "LabelAutoplay";
            this.LabelAutoplay.Size = new System.Drawing.Size(111, 19);
            this.LabelAutoplay.TabIndex = 9;
            this.LabelAutoplay.Text = "自动播放延时(秒):";
            // 
            // CheckBoxR18
            // 
            this.CheckBoxR18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxR18.AutoSize = true;
            this.CheckBoxR18.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckBoxR18.Location = new System.Drawing.Point(440, 523);
            this.CheckBoxR18.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxR18.Name = "CheckBoxR18";
            this.CheckBoxR18.Size = new System.Drawing.Size(52, 23);
            this.CheckBoxR18.TabIndex = 10;
            this.CheckBoxR18.Text = "R18";
            this.CheckBoxR18.UseVisualStyleBackColor = true;
            this.CheckBoxR18.Visible = false;
            this.CheckBoxR18.CheckedChanged += new System.EventHandler(this.CheckBoxR18_CheckedChanged);
            // 
            // TimerAutoplay
            // 
            this.TimerAutoplay.Interval = 30000;
            this.TimerAutoplay.Tick += new System.EventHandler(this.TimerAutoplay_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(888, 25);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.reloadToolStripMenuItem.Text = "重载";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customSetuCountPerRequestToolStripMenuItem,
            this.customMaximumHistoriesToolStripMenuItem,
            this.customLoliconAPIkeyToolStripMenuItem,
            this.LoadSize1200ToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // customSetuCountPerRequestToolStripMenuItem
            // 
            this.customSetuCountPerRequestToolStripMenuItem.Name = "customSetuCountPerRequestToolStripMenuItem";
            this.customSetuCountPerRequestToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.customSetuCountPerRequestToolStripMenuItem.Text = "自定义 单个请求的色图数";
            this.customSetuCountPerRequestToolStripMenuItem.Click += new System.EventHandler(this.customSetuCountPerRequestToolStripMenuItem_Click);
            // 
            // customMaximumHistoriesToolStripMenuItem
            // 
            this.customMaximumHistoriesToolStripMenuItem.Enabled = false;
            this.customMaximumHistoriesToolStripMenuItem.Name = "customMaximumHistoriesToolStripMenuItem";
            this.customMaximumHistoriesToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.customMaximumHistoriesToolStripMenuItem.Text = "自定义 请求历史记录大小(未实现)";
            // 
            // customLoliconAPIkeyToolStripMenuItem
            // 
            this.customLoliconAPIkeyToolStripMenuItem.Name = "customLoliconAPIkeyToolStripMenuItem";
            this.customLoliconAPIkeyToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.customLoliconAPIkeyToolStripMenuItem.Text = "自定义 Lolicon API 密匙";
            this.customLoliconAPIkeyToolStripMenuItem.Click += new System.EventHandler(this.customLoliconAPIkeyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // LoadSize1200ToolStripMenuItem
            // 
            this.LoadSize1200ToolStripMenuItem.Checked = true;
            this.LoadSize1200ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoadSize1200ToolStripMenuItem.Name = "LoadSize1200ToolStripMenuItem";
            this.LoadSize1200ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.LoadSize1200ToolStripMenuItem.Text = "加载 1200 缩略图";
            this.LoadSize1200ToolStripMenuItem.Click += new System.EventHandler(this.LoadSize1200ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ButtonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 571);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.CheckBoxR18);
            this.Controls.Add(this.LabelAutoplay);
            this.Controls.Add(this.TextBoxAutoplayDelay);
            this.Controls.Add(this.ButtonAutoplay);
            this.Controls.Add(this.ButtonInformation);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrevious);
            this.Controls.Add(this.PictureBoxSetu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(904, 610);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoliconGUI";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSetu)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button ButtonAutoplay;
        private System.Windows.Forms.Button ButtonInformation;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrevious;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.CheckBox CheckBoxR18;
        private System.Windows.Forms.Label LabelAutoplay;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox PictureBoxSetu;
        private System.Windows.Forms.TextBox TextBoxAutoplayDelay;
        private System.Windows.Forms.Timer TimerAutoplay;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customLoliconAPIkeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customMaximumHistoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customSetuCountPerRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadSize1200ToolStripMenuItem;
    }
}

