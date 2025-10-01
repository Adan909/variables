using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using variables.Modelos;

namespace variables.Formularios
{
    public partial class FrmArreglo : Form
    {
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int edad = int.Parse(tbEdad.Text);
                Arreglo.edad[Arreglo.pos++] = edad;
                llenarListado();
            }
        }
        public void llenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Arreglo.edad;
            lbEdades.Refresh();
            gbEdades.Text = "Edades: " + Arreglo.edad.Length;
            tbEdad.Text = "";
            tbEdad.Focus();
        }
    }
}
