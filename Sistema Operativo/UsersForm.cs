using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputKey;

namespace Sistema_Operativo
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            RecargarLista();
        }

        bool intercalarPaneles = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        public void RecargarLista()
        {
            StartPosition = FormStartPosition.CenterParent;
            StreamReader reader = new StreamReader("users.txt");
            string line = reader.ReadLine();
            string[] users;
            while (line != null)
            {
                users = line.Split(",");
                listaDeUsuarios.Items.Add(users[0]);
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            listaDeUsuarios.Items.Clear();
            RecargarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsLogin usuario = new ClsLogin(txtUser.Text, txtPass1.Text);
            string pass = InputDialog.mostrar("Introduce la contraseña del administrador");
            if (usuario.verificarAdmin(pass))
            {
                usuario.crearUsuario();
                MessageBox.Show("Usuario creado con exito");
            }
            else
            {
                MessageBox.Show("La contraseña del administrador no es correcta","Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            if (txtPass1.Text != txtPass2.Text)
            {
                errorProvider1.SetError(txtPass2, "Las contraseñas no coindice");
                button1.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                button1.Enabled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string user = listaDeUsuarios.GetItemText(listaDeUsuarios.Items[listaDeUsuarios.SelectedIndex]);
            ClsLogin deleteUser = new ClsLogin(user);
            deleteUser.eliminarUsuario();
            RecargarLista();
        }
    }
}
