using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

                if (Arreglo.pos < 10)
                {
                    Arreglo.edades[Arreglo.pos++] = edad;
                }
                else
                {
                    MessageBox.Show("No se pueden agregar más elementos", "Advertencia", MessageBoxButtons.OK);
                }

                LlenarListado();
                MostrarCalculos();
                Maximo();
                Minimo();
                Mayor();
                Menor();
            }
        }

        private void LlenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Arreglo.edades;
            lbEdades.Refresh();
            gbEdades.Text = "Edades: " + Arreglo.edades.Length;
            tbEdad.Text = "";
            tbEdad.Focus();
        }

        public void MostrarCalculos()
        {
            lblPromedio.Text = "Promedio : " + Arreglo.GetPromedio();
        }

        public void Maximo()
        {
            lblMayor.Text = "Mayor " + Arreglo.GetMax();
        }

        public void Minimo()
        {
            lblMenor.Text = "Menor: " + Arreglo.GetMin();
        }

        public void Mayor()
        {
            lblMayores.Text = "Mayores de edad: " + Arreglo.GetMayoresEdad();
        }
        public void Menor()
        {
            lblMenores.Text = "Menores de edad: " + Arreglo.GetMenoresEdad();
        }
    }
}
