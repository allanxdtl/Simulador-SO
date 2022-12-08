namespace DibujoAplicacion
{
    partial class FrmPaint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaint));
            this.canvas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grisBox = new System.Windows.Forms.PictureBox();
            this.verdeBox = new System.Windows.Forms.PictureBox();
            this.basilBox = new System.Windows.Forms.PictureBox();
            this.rosaBox = new System.Windows.Forms.PictureBox();
            this.lilaBox = new System.Windows.Forms.PictureBox();
            this.blancoBox = new System.Windows.Forms.PictureBox();
            this.mezclillaBox = new System.Windows.Forms.PictureBox();
            this.moradoBox = new System.Windows.Forms.PictureBox();
            this.canvas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grisBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basilBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lilaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blancoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezclillaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.canvas.Controls.Add(this.panel1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(947, 619);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.grisBox);
            this.panel1.Controls.Add(this.verdeBox);
            this.panel1.Controls.Add(this.basilBox);
            this.panel1.Controls.Add(this.rosaBox);
            this.panel1.Controls.Add(this.lilaBox);
            this.panel1.Controls.Add(this.blancoBox);
            this.panel1.Controls.Add(this.mezclillaBox);
            this.panel1.Controls.Add(this.moradoBox);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 103);
            this.panel1.TabIndex = 0;
            // 
            // grisBox
            // 
            this.grisBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.grisBox.Location = new System.Drawing.Point(141, 53);
            this.grisBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grisBox.Name = "grisBox";
            this.grisBox.Size = new System.Drawing.Size(39, 41);
            this.grisBox.TabIndex = 8;
            this.grisBox.TabStop = false;
            this.grisBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // verdeBox
            // 
            this.verdeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.verdeBox.Location = new System.Drawing.Point(95, 53);
            this.verdeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.verdeBox.Name = "verdeBox";
            this.verdeBox.Size = new System.Drawing.Size(39, 41);
            this.verdeBox.TabIndex = 7;
            this.verdeBox.TabStop = false;
            this.verdeBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // basilBox
            // 
            this.basilBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.basilBox.Location = new System.Drawing.Point(49, 53);
            this.basilBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basilBox.Name = "basilBox";
            this.basilBox.Size = new System.Drawing.Size(39, 41);
            this.basilBox.TabIndex = 6;
            this.basilBox.TabStop = false;
            this.basilBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // rosaBox
            // 
            this.rosaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(192)))), ((int)(((byte)(248)))));
            this.rosaBox.Location = new System.Drawing.Point(3, 53);
            this.rosaBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rosaBox.Name = "rosaBox";
            this.rosaBox.Size = new System.Drawing.Size(39, 41);
            this.rosaBox.TabIndex = 5;
            this.rosaBox.TabStop = false;
            this.rosaBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // lilaBox
            // 
            this.lilaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(164)))), ((int)(((byte)(233)))));
            this.lilaBox.Location = new System.Drawing.Point(141, 4);
            this.lilaBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lilaBox.Name = "lilaBox";
            this.lilaBox.Size = new System.Drawing.Size(39, 41);
            this.lilaBox.TabIndex = 4;
            this.lilaBox.TabStop = false;
            this.lilaBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // blancoBox
            // 
            this.blancoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.blancoBox.Location = new System.Drawing.Point(95, 4);
            this.blancoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blancoBox.Name = "blancoBox";
            this.blancoBox.Size = new System.Drawing.Size(39, 41);
            this.blancoBox.TabIndex = 3;
            this.blancoBox.TabStop = false;
            this.blancoBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // mezclillaBox
            // 
            this.mezclillaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(197)))), ((int)(((byte)(226)))));
            this.mezclillaBox.Location = new System.Drawing.Point(49, 4);
            this.mezclillaBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mezclillaBox.Name = "mezclillaBox";
            this.mezclillaBox.Size = new System.Drawing.Size(39, 41);
            this.mezclillaBox.TabIndex = 2;
            this.mezclillaBox.TabStop = false;
            this.mezclillaBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // moradoBox
            // 
            this.moradoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(104)))), ((int)(((byte)(249)))));
            this.moradoBox.Location = new System.Drawing.Point(3, 4);
            this.moradoBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moradoBox.Name = "moradoBox";
            this.moradoBox.Size = new System.Drawing.Size(39, 41);
            this.moradoBox.TabIndex = 1;
            this.moradoBox.TabStop = false;
            this.moradoBox.Click += new System.EventHandler(this.moradoBox_Click);
            // 
            // FrmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 619);
            this.Controls.Add(this.canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPaint";
            this.Text = "Pinta a tu gusto :)";
            this.canvas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grisBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basilBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rosaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lilaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blancoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mezclillaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moradoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvas;
        private PictureBox moradoBox;
        private Panel panel1;
        private PictureBox grisBox;
        private PictureBox verdeBox;
        private PictureBox basilBox;
        private PictureBox rosaBox;
        private PictureBox lilaBox;
        private PictureBox blancoBox;
        private PictureBox mezclillaBox;
    }
}