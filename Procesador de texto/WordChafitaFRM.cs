using System;
using System.Drawing;
using System.Windows.Forms;

namespace Procesador_de_texto
{
    public partial class WordChafitaFRM : Form
    {
        public WordChafitaFRM()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog(this);
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text=r.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "nuevo archivo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if(guardar == DialogResult.OK )
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                };
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void back_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void returnBack_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = colorDialog1.ShowDialog();
            if (c == DialogResult.OK) { 
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formato = fontDialog1.ShowDialog();
            if(formato== DialogResult.OK)
            {
                richTextBox1.Font= fontDialog1.Font;
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse(comBox.SelectedItem.ToString()), richTextBox1.Font.Style);
            }
        }
    }
}
