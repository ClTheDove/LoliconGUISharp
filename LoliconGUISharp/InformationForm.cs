using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LoliconGUISharp
{
    public partial class InformationForm : Form
    {
        private readonly Setu setu;

        public InformationForm(Setu setu)
        {
            this.setu = setu;
            InitializeComponent();
            TextBoxPid.Text = setu?.pid?.ToString();
            TextBoxP.Text = setu?.p?.ToString();
            TextBoxUid.Text = setu?.uid?.ToString();
            TextBoxTitle.Text = setu?.title;
            TextBoxAuthor.Text = setu?.author;
            TextBoxURL.Text = setu?.url;
            LabelR18.Text = $"R18: {(NullableBooleanToBoolean(setu?.r18?.Equals(true)) ? "是" : "否")}";
            TextBoxWidth.Text = setu?.width?.ToString();
            TextBoxHeight.Text = setu?.height?.ToString();
            TextBoxTags.Text = string.Join(" ", setu?.tags);
        }

        private static bool NullableBooleanToBoolean(bool? value)
        {
            return value.Equals(true);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonViewOnPixiv_Click(object sender, EventArgs e)
        {
            Process.Start($@"https://www.pixiv.net/artworks/{setu?.pid}");
        }
    }
}