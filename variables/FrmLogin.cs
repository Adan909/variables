using System;
using System.Windows.Forms;

namespace variables
{
    public partial class FrmLogin : Form
    {
        // Variable global (de clase)
        private int intentos = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(tbUser.Text, tbPassword.Text))
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                intentos++; 
                MessageBox.Show("Usuario o contraseña incorrectos. Intento " + intentos);

                if (intentos == 3)
                {
                    MessageBox.Show("Has superado el número de intentos. Cerrando...");
                    this.Close();
                }
            }
        }

        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
