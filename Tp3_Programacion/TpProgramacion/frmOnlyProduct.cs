using domain;
using services;
using System;
using System.Windows.Forms;

namespace TpProgramacion.services
{
    public partial class frmOnlyProduct : Form
    {
        public frmOnlyProduct()
        {
            InitializeComponent();
        }

        private void btnCodigo__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            Product producto = cc.buscarPorCod(txtBCodigo.Text);

            if (producto != null)
            {
                lblR1__only.Text = producto.codArticulo;
                lblR2__only.Text = producto.Nombre;
                lblR4__only.Text = producto.Precio.ToString();
                lblR5__only.Text = producto.Marca.Description;
                pbxImagen__only.Load(producto.urlImagen);
            }
            else
            {
                MessageBox.Show("No se encontro articulo.");
            }

        }

        private void btnNombre__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            Product productobuscado = cc.buscarPorNombre(txtBNombre.Text);

            if (productobuscado != null)
            {
                lblR1__only.Text = productobuscado.codArticulo;
                lblR2__only.Text = productobuscado.Nombre;
                lblR4__only.Text = productobuscado.Precio.ToString();
                lblR5__only.Text = productobuscado.Marca.Description;
                pbxImagen__only.Load(productobuscado.urlImagen);
            }
            else
            {
                MessageBox.Show("No se encontro articulo.");
            }

        }

        private void frmOnlyProduct_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregar__only_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevoProducto = new frmNuevoProducto();
            nuevoProducto.ShowDialog();
        }
    }
}
