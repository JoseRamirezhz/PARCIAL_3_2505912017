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
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario3 form3 = new Formulario3();
            form3.ShowDialog();
        }

        private void Formulario2_Load(object sender, EventArgs e)
        {
            //maximinza el formulario
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void formulario4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario4 form4 = new Formulario4();
            form4.ShowDialog();
        }

        private void btnSalirForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
