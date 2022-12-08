namespace Sistema_Operativo
{
    partial class FormPantallaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCalculadora = new System.Windows.Forms.PictureBox();
            this.buttonPaint = new System.Windows.Forms.PictureBox();
            this.buttonNavegador = new System.Windows.Forms.PictureBox();
            this.buttonMusica = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonWin = new System.Windows.Forms.PictureBox();
            this.buttonJuego = new System.Windows.Forms.PictureBox();
            this.buttonTexto = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnOff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCalculadora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNavegador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMusica)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTexto)).BeginInit();
            this.panMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculadora
            // 
            this.buttonCalculadora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalculadora.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalculadora.Image = global::Sistema_Operativo.Properties.Resources.calculadoraicono;
            this.buttonCalculadora.Location = new System.Drawing.Point(264, 11);
            this.buttonCalculadora.Name = "buttonCalculadora";
            this.buttonCalculadora.Size = new System.Drawing.Size(77, 73);
            this.buttonCalculadora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonCalculadora.TabIndex = 0;
            this.buttonCalculadora.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonCalculadora, "Calculadora");
            this.buttonCalculadora.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonPaint
            // 
            this.buttonPaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPaint.BackColor = System.Drawing.Color.Transparent;
            this.buttonPaint.Image = global::Sistema_Operativo.Properties.Resources.dibujoicono;
            this.buttonPaint.Location = new System.Drawing.Point(15, 11);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(77, 73);
            this.buttonPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPaint.TabIndex = 1;
            this.buttonPaint.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonPaint, "Dibujar!");
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // buttonNavegador
            // 
            this.buttonNavegador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNavegador.BackColor = System.Drawing.Color.Transparent;
            this.buttonNavegador.Image = global::Sistema_Operativo.Properties.Resources.juego2icono;
            this.buttonNavegador.Location = new System.Drawing.Point(98, 11);
            this.buttonNavegador.Name = "buttonNavegador";
            this.buttonNavegador.Size = new System.Drawing.Size(77, 73);
            this.buttonNavegador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonNavegador.TabIndex = 2;
            this.buttonNavegador.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonNavegador, "Navegador web");
            this.buttonNavegador.Click += new System.EventHandler(this.buttonNavegador_Click);
            // 
            // buttonMusica
            // 
            this.buttonMusica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMusica.BackColor = System.Drawing.Color.Transparent;
            this.buttonMusica.Image = global::Sistema_Operativo.Properties.Resources.musicaicono;
            this.buttonMusica.Location = new System.Drawing.Point(181, 11);
            this.buttonMusica.Name = "buttonMusica";
            this.buttonMusica.Size = new System.Drawing.Size(77, 73);
            this.buttonMusica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonMusica.TabIndex = 3;
            this.buttonMusica.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonMusica, "Reproductor de musica");
            this.buttonMusica.Click += new System.EventHandler(this.buttonMusica_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.buttonWin);
            this.panel1.Controls.Add(this.buttonJuego);
            this.panel1.Controls.Add(this.buttonTexto);
            this.panel1.Controls.Add(this.buttonPaint);
            this.panel1.Controls.Add(this.buttonCalculadora);
            this.panel1.Controls.Add(this.buttonMusica);
            this.panel1.Controls.Add(this.buttonNavegador);
            this.panel1.Location = new System.Drawing.Point(17, 975);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1895, 90);
            this.panel1.TabIndex = 5;
            // 
            // buttonWin
            // 
            this.buttonWin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWin.BackColor = System.Drawing.Color.Transparent;
            this.buttonWin.Image = global::Sistema_Operativo.Properties.Resources.soiconio;
            this.buttonWin.Location = new System.Drawing.Point(1798, 9);
            this.buttonWin.Name = "buttonWin";
            this.buttonWin.Size = new System.Drawing.Size(77, 73);
            this.buttonWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonWin.TabIndex = 7;
            this.buttonWin.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonWin, "Juego");
            this.buttonWin.Click += new System.EventHandler(this.buttonWin_Click);
            // 
            // buttonJuego
            // 
            this.buttonJuego.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonJuego.BackColor = System.Drawing.Color.Transparent;
            this.buttonJuego.Image = global::Sistema_Operativo.Properties.Resources.juegoicono;
            this.buttonJuego.Location = new System.Drawing.Point(430, 11);
            this.buttonJuego.Name = "buttonJuego";
            this.buttonJuego.Size = new System.Drawing.Size(77, 73);
            this.buttonJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonJuego.TabIndex = 6;
            this.buttonJuego.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonJuego, "Juego");
            this.buttonJuego.Click += new System.EventHandler(this.buttonJuego_Click);
            // 
            // buttonTexto
            // 
            this.buttonTexto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTexto.BackColor = System.Drawing.Color.Transparent;
            this.buttonTexto.Image = global::Sistema_Operativo.Properties.Resources.textoicono;
            this.buttonTexto.Location = new System.Drawing.Point(347, 11);
            this.buttonTexto.Name = "buttonTexto";
            this.buttonTexto.Size = new System.Drawing.Size(77, 73);
            this.buttonTexto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonTexto.TabIndex = 5;
            this.buttonTexto.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonTexto, "GAIA, editor de texto");
            this.buttonTexto.Click += new System.EventHandler(this.procesador);
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panMenu.Controls.Add(this.btnOff);
            this.panMenu.Controls.Add(this.button1);
            this.panMenu.Location = new System.Drawing.Point(1698, 815);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(212, 151);
            this.panMenu.TabIndex = 6;
            this.panMenu.Visible = false;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(10, 92);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(191, 29);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Apagar sistema";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestionar usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Sistema_Operativo.Properties.Resources.andromedaspng;
            this.ClientSize = new System.Drawing.Size(1924, 1077);
            this.ControlBox = false;
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPantallaPrincipal";
            this.ShowIcon = false;
            this.Text = "Andromeda SO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.FormPantallaPrincipal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.buttonCalculadora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNavegador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMusica)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTexto)).EndInit();
            this.panMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox buttonCalculadora;
        private PictureBox buttonPaint;
        private PictureBox buttonNavegador;
        private PictureBox buttonMusica;
        private Panel panel1;
        private ToolTip toolTip1;
        private PictureBox buttonTexto;
        private PictureBox buttonJuego;
        private PictureBox buttonWin;
        private Panel panMenu;
        private Button btnOff;
        private Button button1;
    }
}