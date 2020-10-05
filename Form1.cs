using NetPad.Controls;
using NetPad.Objects;
using System.Windows.Forms;

namespace NetPad
{
    public partial class MainForm : Form
    {
        public RichTextBox CurrentRtb;
        public TextFile CurrentFile;
        public TabControl MainTabControl;
        public Session Session;

        public MainForm()
        {
            InitializeComponent();

            Session = new Session();

            var menuStrip = new MainMenuStrip();
            MainTabControl = new MainTabControl();

            TextFile file = new TextFile("c:/test.txt");

            Controls.AddRange(new Control[] { MainTabControl, menuStrip });

            InitializeFile();

        }

        private void InitializeFile()
        {
            if (Session.TextFiles.Count == 0)
            {
                var file = new TextFile("Sans Titre 1");

                MainTabControl.TabPages.Add(file.SafeFileName);

                var tabPage = MainTabControl.TabPages[0];
                var rtb = new CustomRichTextBox();
                tabPage.Controls.Add(rtb);
                rtb.Select();

                Session.TextFiles.Add(file);

                CurrentFile = file;
                CurrentRtb = rtb;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Session.Save();
        }
    }
}
