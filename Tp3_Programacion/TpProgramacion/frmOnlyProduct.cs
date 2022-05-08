using domain;
using services;
using System;
using System.Windows.Forms;
using helpers;

namespace TpProgramacion.services
{
    public partial class frmOnlyProduct : Form
    {

        private Product productoBuscado = null;

        public frmOnlyProduct(Product product)
        {
            InitializeComponent();
            this.productoBuscado = product;
        }

        private void btnCodigo__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            productoBuscado = cc.buscarPorCod(txtBCodigo.Text);

            showInfoProduct(productoBuscado);

        }

        private void btnNombre__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            productoBuscado = cc.buscarPorNombre(txtBNombre.Text);

            showInfoProduct(productoBuscado);
        }

        private void frmOnlyProduct_Load(object sender, EventArgs e)
        {
            if (productoBuscado != null)
            {
                Text = "Detalles del Articulo";
                //pnlBuscar.Visible = false;
                btnAgregar__only.Visible = false;
                showInfoProduct(productoBuscado);
            }
            else
            {
                Text = "Buscar Articulo";
            }
        }

        private void btnAgregar__only_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevoProducto = new frmNuevoProducto(null);
            nuevoProducto.ShowDialog();
        }

        private void btnEditar__only_Click(object sender, EventArgs e)
        {
            if(productoBuscado == null)
            {
                MessageBox.Show("Primero debe buscar el articulo que quiere editar.");
                return;
            }
            frmNuevoProducto editar = new frmNuevoProducto(productoBuscado);
            editar.ShowDialog();

        }

        private void btnBorrar__only_Click(object sender, EventArgs e)
        {
            if (productoBuscado == null)
            {
                MessageBox.Show("Primero debe buscar el articulo que quiere borrar.");
                return;
            }

            CommerceConnecction cc = new CommerceConnecction();
            
            if (cc.deleteProduct(productoBuscado.codArticulo) == 1)
            {
                MessageBox.Show("Articulo eliminado de la Base de Datos");
                return;
            }
            MessageBox.Show("Ocurrio un error al eliminar el articulo");
        }

        private void showInfoProduct(Product showProduct)
        {
            if (showProduct != null)
            {
                lblR1__only.Text = showProduct.codArticulo;
                lblR2__only.Text = showProduct.Nombre;
                lblR4__only.Text = showProduct.Precio.ToString();
                lblR5__only.Text = showProduct.Marca.Description;
                ImageHelper.LoadImage(pbxImagen__only, showProduct.urlImagen);
            }
            else
            {
                MessageBox.Show("No se encontro articulo.");
            }
        }
    }
}
