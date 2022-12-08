using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        bool play = false;
        string[] archivosMp3;
        string[] rutas;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Reproductor.URL = "C:\\Users\\Allan\\Desktop\\valeri.mp3";
        }

        private void picPlayPause_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    picPlayPause.Image = Properties.Resources.pause;
                    play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    picPlayPause.Image = Properties.Resources.play;
                    play = true;
                    break;
            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Multiselect = true;
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                archivosMp3 = buscador.SafeFileNames;
                rutas = buscador.FileNames;
                foreach (var archivos in archivosMp3)
                {
                    listaReproduccion.Items.Add(archivos);
                }
                Reproductor.URL = rutas[0];
                listaReproduccion.SelectedIndex = 0;
            }
        }

        private void listaReproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutas[listaReproduccion.SelectedIndex];
        }

        public void ActualizarDatosDeCancion()
        {
            if(Reproductor.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                tcrStatus.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if(Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }else if(Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                tcrStatus.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosDeCancion();
            tcrStatus.Value = (int)Reproductor.Ctlcontrols.currentPosition;
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosDeCancion();
        }

        private void trbVolumen_Scroll(object sender, EventArgs e)
        {
            trbVolumen.Maximum = 100;
            trbVolumen.Minimum = 0;
            Reproductor.settings.volume = trbVolumen.Value;
            if (trbVolumen.Value == 0)
            {
                pictureBox2.Image = Properties.Resources.silence;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.sound;
            }
        }

        private void tcrStatus_Scroll(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.currentPosition = tcrStatus.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.next();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Reproductor.settings.volume > 0)
            {
                pictureBox2.Image = Properties.Resources.silence;
                Reproductor.settings.volume = 0;
                trbVolumen.Value = 0;
            }
            else{
                pictureBox2.Image = Properties.Resources.sound;
                Reproductor.settings.volume = 50;
                trbVolumen.Value = 50;
            }
        }
    }
}
