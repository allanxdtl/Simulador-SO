using System.Security.Cryptography;
using System.Text;

namespace Sistema_Operativo
{
    internal class ClsLogin
    {
        private TextReader reader;
        private TextWriter writer;
        private string user;
        private string pass;
        private bool iniciado;
        private Form pantalla;

        public ClsLogin(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
            iniciado = false;
        }

        public ClsLogin(string user)
        {
            this.user=user;
        }

        public bool verificarAdmin(string pass)
        {
            reader = new StreamReader("users.txt");
            string line = reader.ReadLine();
            string[] admin = line.Split(",");
            if (convertirCifrado(pass) == admin[1])
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public void crearUsuario()
        {
            writer = File.AppendText("users.txt");
            writer.WriteLine($"{user},{convertirCifrado(pass)}");
            writer.Write("\n");
            writer.Close();
        }

        public void eliminarUsuario()
        {
            reader = new StreamReader("users.txt");
            string cadena=reader.ReadLine();
            List<string> usuarios = new List<string>();
            while (!cadena.Contains($"{user}") && cadena!=null)
            {
                usuarios.Add(cadena);
                cadena= reader.ReadLine();
            }
            reader.Close();

            writer = new StreamWriter("users.txt");
            for(int i=0; i<usuarios.Count; i++)
            {
                writer.WriteLine(usuarios[i]);
            }
            writer.Close();
        }

        public void Log()
        {
            string[] user;
            reader = new StreamReader("users.txt");
            string line = reader.ReadLine();
            while(line!= null)
            {
                user=line.Split(',');
                if (user[0]==this.user && compararConCifrado(user[1]))
                {
                    reader.Close();
                    MessageBox.Show("Bienvenido a Andromeda SO");
                    FrmScreenLoad load = new FrmScreenLoad();
                    load.StartPosition=FormStartPosition.CenterScreen;
                    load.Show();
                    iniciado= true;
                    return;
                }
                else if (user[0]==this.user && user[1] != this.pass)
                {
                    MessageBox.Show("La contraseña es incorrecta, vuelve a intentarlo o contactate con el admin ");
                    return;
                }
                line=reader.ReadLine();
            }
            reader.Close();
            MessageBox.Show("Su usuario no existe");
        }

        private bool compararConCifrado(string pass)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(this.pass);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();

            for(int i=0; i<result.Length; i++)
            {
                sb.AppendFormat("{0:x2}",result[i]);
            }

            if (sb.ToString().ToUpper() == pass)
            {
                return true;
            }
            return false;
        }

        private string convertirCifrado(string pass)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(pass);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
            {
                sb.AppendFormat("{0:x2}", result[i]);
            }
            return sb.ToString().ToUpper();
        }

        public bool Iniciado
        {
            get { return iniciado; }
        }
    }
}
