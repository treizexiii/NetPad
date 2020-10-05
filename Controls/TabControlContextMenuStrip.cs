using System.Windows.Forms;

namespace NetPad.Controls
{
    public class TabControlContextMenuStrip : ContextMenuStrip
    {
        private const string NAME = "TabControlContextMenuString";

        public TabControlContextMenuStrip()
        {
            Name = NAME;

            var closeTab = new ToolStripMenuItem("Fermer");
            var closeTabAllTabExceptThis = new ToolStripMenuItem("Fermer tout sauf ce fichier");
            var opentFileInExplorer = new ToolStripMenuItem("Ouvrir le répertoire du fichier en cours");

            Items.AddRange(new ToolStripItem[] { closeTab, closeTabAllTabExceptThis, opentFileInExplorer });
        }
    }
}
