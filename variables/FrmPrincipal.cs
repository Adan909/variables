using System;
using System.Windows.Forms;
using variables.Modelos;

namespace variables
{
    public partial class FrmPrincipal : Form
    {
        Facultad fac = new Facultad();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }

}

       