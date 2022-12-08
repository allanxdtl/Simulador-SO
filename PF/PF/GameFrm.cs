using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF
{
    public partial class GameFrm : Form
    {
        public int[,] matriz = new int[4, 4];
        Random num = new Random();

        public GameFrm()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 4;
            dataGridView1.RowHeadersWidth = 70;


            for (int f = 0; f < 4; f++)
            {
                if (f==0)
                {
                    dataGridView1.Rows[f].HeaderCell.Value = Convert.ToString("1");
                    dataGridView1.Columns[f].HeaderCell.Value = Convert.ToString("Accesorios");
                dataGridView1.AutoResizeColumn(f);
                }
                if (f == 1)
                {
                    dataGridView1.Rows[f].HeaderCell.Value = Convert.ToString("2");
                    dataGridView1.Columns[f].HeaderCell.Value = Convert.ToString("Blusa");
                    dataGridView1.AutoResizeColumn(f);
                }
                if (f == 2)
                {
                    dataGridView1.Rows[f].HeaderCell.Value = Convert.ToString("3");
                    dataGridView1.Columns[f].HeaderCell.Value = Convert.ToString("Pantalon/Falda");
                    dataGridView1.AutoResizeColumn(f);
                }
                if (f == 3)
                {
                    dataGridView1.Rows[f].HeaderCell.Value = Convert.ToString("4");
                    dataGridView1.Columns[f].HeaderCell.Value = Convert.ToString("Zapatos");
                    dataGridView1.AutoResizeColumn(f);
                }

            }

            
            pictureBox1.BackColor = Color.Transparent;//transparencia respetada
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    int val2 = Convert.ToInt32(dataGridView1[f, c].Value);
                        if (val2 == 1)
                        {
                            if (f == 0)//ACCESORIOS
                            {
                                if (c == 0)
                                {
                                pictureBox6.Visible = true;
                                pictureBox1.Controls.Add(pictureBox6);// referente a
                                pictureBox6.Location = new Point(0, 0);// dentro del fondo
                                pictureBox6.BackColor = Color.Transparent;//transparencia
                            }
                                if (c == 1)
                                {
                                pictureBox7.Visible = true;
                                pictureBox1.Controls.Add(pictureBox7);// referente a
                                pictureBox7.Location = new Point(0, 0);// dentro del fondo
                                pictureBox7.BackColor = Color.Transparent;//transparencia

                            }
                                else if (c == 2)
                                {
                                pictureBox8.Visible = true;
                                pictureBox1.Controls.Add(pictureBox8);// referente a
                                pictureBox8.Location = new Point(0, 0);// dentro del fondo
                                pictureBox8.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 3)
                                {
                                pictureBox9.Visible = true;
                                pictureBox1.Controls.Add(pictureBox9);// referente a
                                pictureBox9.Location = new Point(0, 0);// dentro del fondo
                                pictureBox9.BackColor = Color.Transparent;//transparencia
                            }
                            }
                            else if (f == 1)//BLUSAS
                            {
                                if (c == 0)
                                {
                                pictureBox2.Visible = true;
                                pictureBox1.Controls.Add(pictureBox2);// referente a
                                pictureBox2.Location = new Point(0, 0);// dentro del fondo
                                pictureBox2.BackColor = Color.Transparent;//transparencia

                            }
                            else if (c == 1)
                                {
                                pictureBox3.Visible = true;
                                pictureBox1.Controls.Add(pictureBox3);// referente a
                                pictureBox3.Location = new Point(0, 0);// dentro del fondo
                                pictureBox3.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 2)
                                {
                                pictureBox4.Visible = true;
                                pictureBox1.Controls.Add(pictureBox4);// referente a
                                pictureBox4.Location = new Point(0, 0);// dentro del fondo
                                pictureBox4.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 3)
                                {
                                pictureBox5.Visible = true;
                                pictureBox1.Controls.Add(pictureBox5);// referente a
                                pictureBox5.Location = new Point(0, 0);// dentro del fondo
                                pictureBox5.BackColor = Color.Transparent;//transparencia

                            }
                            }
                            else if (f == 2)//FALDAS
                            {
                                if (c == 0)
                                {
                                pictureBox10.Visible = true;
                                pictureBox1.Controls.Add(pictureBox10);// referente a
                                pictureBox10.Location = new Point(0, 0);// dentro del fondo
                                pictureBox10.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 1)
                                {
                                pictureBox11.Visible = true;
                                pictureBox1.Controls.Add(pictureBox11);// referente a
                                pictureBox11.Location = new Point(0, 0);// dentro del fondo
                                pictureBox11.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 2)
                                {
                                pictureBox12.Visible = true;
                                pictureBox1.Controls.Add(pictureBox12);// referente a
                                pictureBox12.Location = new Point(0, 0);// dentro del fondo
                                pictureBox12.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 3)
                                {
                                pictureBox13.Visible = true;
                                pictureBox1.Controls.Add(pictureBox13);// referente a
                                pictureBox13.Location = new Point(0, 0);// dentro del fondo
                                pictureBox13.BackColor = Color.Transparent;//transparencia

                            }
                            }
                            else if (f == 3)//ZAPATOS
                            {
                                if (c == 0)
                                {
                                pictureBox14.Visible = true;
                                pictureBox1.Controls.Add(pictureBox14);// referente a
                                pictureBox14.Location = new Point(0, 0);// dentro del fondo
                                pictureBox14.BackColor = Color.Transparent;//transparencia

                            }
                                else if (c == 1)
                                {
                                pictureBox15.Visible = true;
                                pictureBox1.Controls.Add(pictureBox15);// referente a
                                pictureBox15.Location = new Point(0, 0);// dentro del fondo
                                pictureBox15.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 2)
                                {
                                pictureBox16.Visible = true;
                                pictureBox1.Controls.Add(pictureBox16);// referente a
                                pictureBox16.Location = new Point(0, 0);// dentro del fondo
                                pictureBox16.BackColor = Color.Transparent;//transparencia
                            }
                                else if (c == 3)
                                {
                                pictureBox17.Visible = true;
                                pictureBox1.Controls.Add(pictureBox17);// referente a
                                pictureBox17.Location = new Point(0, 0);// dentro del fondo
                                pictureBox17.BackColor = Color.Transparent;//transparencia

                            }
                            }
                        }
                    
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = null;
                }
            }

            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

        }



        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (val != 0 && val != 1)
            {
                MessageBox.Show("Valor no valido :P");
                dataGridView1.CurrentCell.Value = null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)

                {
                    dataGridView1[c, f].Value = num.Next(2);
                }
            }
        }
    }
}
