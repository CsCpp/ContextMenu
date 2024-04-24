namespace ContextMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void ÍÓÔËÓ‚‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
            }
            catch (Exception)
            {

            }

        }

        private void ‚ÒÚ‡‚ËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Clipboard.GetText());
        }
    }
}
