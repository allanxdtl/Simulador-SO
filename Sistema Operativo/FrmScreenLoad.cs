using CalculadoraAplicacion;
using DibujoAplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Operativo
{
    public partial class FrmScreenLoad : Form
    {
        public FrmScreenLoad()
        {
            InitializeComponent();
            progressBar1.Minimum= 0;
            progressBar1.Maximum= 100;
            load.Start();
            

        }

        private void load_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                FormPantallaPrincipal pantallaPrincipal = new FormPantallaPrincipal();
                pantallaPrincipal.Show();
                load.Stop();
                Dispose();
            }
        }
    }
}
