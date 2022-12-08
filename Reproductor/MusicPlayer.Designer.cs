namespace Reproductor
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.picPlayPause = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.tcrStatus = new System.Windows.Forms.TrackBar();
            this.trbVolumen = new System.Windows.Forms.TrackBar();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.listaReproduccion = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcrStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayPause
            // 
            this.picPlayPause.Image = global::Reproductor.Properties.Resources.play;
            this.picPlayPause.Location = new System.Drawing.Point(263, 227);
            this.picPlayPause.Name = "picPlayPause";
            this.picPlayPause.Size = new System.Drawing.Size(83, 79);
            this.picPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayPause.TabIndex = 2;
            this.picPlayPause.TabStop = false;
            this.picPlayPause.Click += new System.EventHandler(this.picPlayPause_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reproductor.Properties.Resources.sound;
            this.pictureBox2.Location = new System.Drawing.Point(267, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(158, 500);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(236, 58);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.Visible = false;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // tcrStatus
            // 
            this.tcrStatus.Location = new System.Drawing.Point(1, 115);
            this.tcrStatus.Name = "tcrStatus";
            this.tcrStatus.Size = new System.Drawing.Size(306, 56);
            this.tcrStatus.TabIndex = 7;
            this.tcrStatus.Scroll += new System.EventHandler(this.tcrStatus_Scroll);
            // 
            // trbVolumen
            // 
            this.trbVolumen.Location = new System.Drawing.Point(315, 39);
            this.trbVolumen.Maximum = 100;
            this.trbVolumen.Name = "trbVolumen";
            this.trbVolumen.Size = new System.Drawing.Size(79, 56);
            this.trbVolumen.TabIndex = 8;
            this.trbVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbVolumen.Scroll += new System.EventHandler(this.trbVolumen_Scroll);
            // 
            // picAdd
            // 
            this.picAdd.Image = global::Reproductor.Properties.Resources.sound;
            this.picAdd.Location = new System.Drawing.Point(263, 337);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(83, 79);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 9;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // listaReproduccion
            // 
            this.listaReproduccion.FormattingEnabled = true;
            this.listaReproduccion.ItemHeight = 16;
            this.listaReproduccion.Location = new System.Drawing.Point(12, 177);
            this.listaReproduccion.Name = "listaReproduccion";
            this.listaReproduccion.Size = new System.Drawing.Size(245, 260);
            this.listaReproduccion.TabIndex = 10;
            this.listaReproduccion.SelectedIndexChanged += new System.EventHandler(this.listaReproduccion_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(406, 537);
            this.Controls.Add(this.listaReproduccion);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.trbVolumen);
            this.Controls.Add(this.tcrStatus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picPlayPause);
            this.Controls.Add(this.Reproductor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayer";
            this.Text = "Música";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcrStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.PictureBox picPlayPause;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar tcrStatus;
        private System.Windows.Forms.TrackBar trbVolumen;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.ListBox listaReproduccion;
        private System.Windows.Forms.Timer timer1;
    }
}

