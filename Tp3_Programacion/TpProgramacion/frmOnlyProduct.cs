using domain;
using services;
using System;
using System.Windows.Forms;

namespace TpProgramacion.services
{
    public partial class frmOnlyProduct : Form
    {

        private Product productoBuscado;

        public frmOnlyProduct()
        {
            InitializeComponent();
            Text = "Busqueda Especifica";
        }

        public void imageLoad(string e)
        {
            try
            {
                pbxImagen__only.Load(e);
            }
            catch (Exception)
            {

                pbxImagen__only.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/1024px-No_image_available.svg.png");
            }
        }

        private void btnCodigo__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            productoBuscado = cc.buscarPorCod(txtBCodigo.Text);

            if (productoBuscado != null)
            {
                lblR1__only.Text = productoBuscado.codArticulo;
                lblR2__only.Text = productoBuscado.Nombre;
                lblR4__only.Text = productoBuscado.Precio.ToString();
                lblR5__only.Text = productoBuscado.Marca.Description;
                imageLoad(productoBuscado.urlImagen);
            }
            else
            {
                MessageBox.Show("No se encontro articulo.");
            }

        }

        private void btnNombre__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            productoBuscado = cc.buscarPorNombre(txtBNombre.Text);

            if (productoBuscado != null)
            {
                lblR1__only.Text = productoBuscado.codArticulo;
                lblR2__only.Text = productoBuscado.Nombre;
                lblR4__only.Text = productoBuscado.Precio.ToString();
                lblR5__only.Text = productoBuscado.Marca.Description;
                imageLoad(productoBuscado.urlImagen);
            }
            else
            {
                MessageBox.Show("No se encontro articulo.");
            }

        }

        private void frmOnlyProduct_Load(object sender, EventArgs e)
        {
            productoBuscado = null;
        }

        private void btnAgregar__only_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevoProducto = new frmNuevoProducto();
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
            
            if (cc.deleteProduct(productoBuscado.codArticulo) == 0)
            {
                MessageBox.Show("Articulo eliminado de la Base de Datos");
                return;
            }
            MessageBox.Show("Ocurrio un error al eliminar el articulo");

        }

        private void pbxImagen__only_Click(object sender, EventArgs e)
        {

        }
    }
}
