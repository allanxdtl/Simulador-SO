using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class WebFRM : Form
    {
        public WebFRM()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web.Update();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            web.Navigate(txtURL.Text);
        }

        private void txtURL_Enter(object sender, EventArgs e)
        {
            web.Navigate(txtURL.Text);
        }
    }
}
