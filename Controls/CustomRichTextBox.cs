using System.Drawing;
using System.Windows.Forms;

namespace NetPad.Controls
{
    public class CustomRichTextBox : RichTextBox
    {
        private const string NAME = "RTBTexFileContents";

        public CustomRichTextBox()
        {
            Name = NAME;
            AcceptsTab = true;
            Font = new Font("Arial", 12.0F, FontStyle.Regular);
            Dock = DockStyle.Fill;
            BorderStyle = BorderStyle.None;
            ContextMenuStrip = new RichTextBoxContextMenuStrip(this);
        }
    }
}
