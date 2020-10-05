using System.Windows.Forms;

namespace NetPad.Controls
{
    public class MainTabControl : TabControl
    {
        private const string NAME = "MainTabControl";
        private TabControlContextMenuStrip _ContextMenuStrip;

        public MainTabControl()
        {
            _ContextMenuStrip = new TabControlContextMenuStrip();
            Name = NAME;
            ContextMenuStrip = _ContextMenuStrip;
            Dock = DockStyle.Fill;
        }
    }
}
