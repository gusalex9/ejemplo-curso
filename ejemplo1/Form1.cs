using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem;
            elem = txtNombre.Text;

            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxColorFavorito.Items.Add("Blanco");
            cbxColorFavorito.Items.Add("Negro");
            cbxColorFavorito.Items.Add("Verde");
            cbxColorFavorito.Items.Add("Amarillo");
            cbxColorFavorito.Items.Add("Azul");
            cbxColorFavorito.Items.Add("Rojo");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = txtNombre.Text;

            DateTime fecha;
            fecha = dtpFechaNacimiento.Value;

            string chocolate = ckbChocolate.Checked ? "Le gusta el chocolate" : "No le gusta el chocolate";

            string tipo;

            if (rbtWizard.Checked)
            
                tipo = "Wizard";
            
            else if (rbtMuggle.Checked)
            
                tipo = "Muggle";
            
            else
                tipo = "Squibs";

            string colorFavorito = cbxColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            MessageBox.Show("Nombre: " + nombre + ", Fecha de nacimiento: " + fecha + ", " + chocolate + ", es un " + tipo + ", color favorito: " + colorFavorito + ", numero favorito: " + numeroFavorito);
        }
    }
}
