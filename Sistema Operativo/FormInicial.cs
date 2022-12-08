namespace Sistema_Operativo
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void btnLog_Click(object sender, EventArgs e)
        {
            ClsLogin login = new ClsLogin(txtUser.Text, txtPass.Text);
            login.Log();
            if (login.Iniciado)
            {
                Hide();
            }
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}