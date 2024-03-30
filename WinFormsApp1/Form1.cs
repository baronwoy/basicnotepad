using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clears the notepad of all text
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // shows a pop-up box to where a user can search a directory to open a file of their choosing
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }

            // shows a pop-up message if the file cannot be opened
            else if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Error opening file.");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sets the default extension of the saved file to .txt
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text file |*.txt|Markdown File |*.md";

            // Shows a pop-uo to which a user can save their work
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // No difference to save as function at the current moment
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text file |*.txt|Markdown File |*.md";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // allows user to cut pieces of text to paste to their desired position
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // allows user to copy text they have highlighted
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // allows user to paste copied text
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // allows user to undo text they have typed in
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // allows the user to redo after undoing
            richTextBox1.Redo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Shows a pop-up box where a user can change the color of the background
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Shows a pop-up box where a user can change the color of their text
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
