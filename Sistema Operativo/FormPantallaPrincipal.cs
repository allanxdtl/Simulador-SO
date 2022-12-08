using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reproductor;
using Navegador;
using Procesador_de_texto;
using PF;
using DibujoAplicacion;
using CalculadoraAplicacion;

namespace Sistema_Operativo
{
    public partial class FormPantallaPrincipal : Form
    {
        //Esta variable es para alternar el menu de opciones del icono principal
        bool panel = false;

        public FormPantallaPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DoubleBuffered = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Inicia la calculadora
            Form1 caluladora = new();
            caluladora.Show();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            //Inicia el paint
            FrmPaint paint = new();
            paint.Show();
        }

        private void bttnExit_Click(object sender, EventArgs e)
        {
            //Boton para cerrar el sistema
            Application.Exit();
        }

        private void buttonMusica_Click(object sender, EventArgs e)
        {
            //Inicia el reproductor de musica
            MusicPlayer wind = new();
            wind.Show();
        }

        private void buttonNavegador_Click(object sender, EventArgs e)
        {
            //Abre el navegador
            WebFRM nav = new WebFRM();
            nav.Show();
        }

        private void procesador(object sender, EventArgs e)
        {
            //Abre el word chafita
            WordChafitaFRM frm = new WordChafitaFRM();
            frm.Show(this);
        }

        private void buttonJuego_Click(object sender, EventArgs e)
        {
            GameFrm game = new GameFrm();
            game.Show();
        }

        private void buttonWin_Click(object sender, EventArgs e)
        {
            if (panel)
            {
                panMenu.Visible = false;
                panel= false;
            }
            else
            {
                panMenu.Visible = true;
                panel = true;
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPantallaPrincipal_Click(object sender, EventArgs e)
        {
            panel = false;
            panMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm();
            form.Show(this);
        }
    }
}
