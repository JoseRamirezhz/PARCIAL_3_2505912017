using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialNumero3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String Usuario, Contra;

            Usuario = txtUsuario.Text;
            Contra = txtContraseña.Text;

            if (Usuario == "admin" && Contra == "123")
            {
                Formulario2 form2 = new Formulario2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorectos");
            }
        }
    }
}
