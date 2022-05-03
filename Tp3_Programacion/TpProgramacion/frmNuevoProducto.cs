using domain;
using services;
using System;
using System.Data;
using System.Windows.Forms;

namespace TpProgramacion
{
    public partial class frmNuevoProducto : Form
    {

        private Product product = null;
        public frmNuevoProducto()
        {
            InitializeComponent();
            Text = "Nuevo Producto";
        }

        public frmNuevoProducto(Product edit)
        {
            InitializeComponent();
            this.product = edit;
            Text = "Modificar Producto";
        }

        private void btnAgregar__Nuevo_Click(object sender, EventArgs e)
        {
            CommerceConnecction CC = new CommerceConnecction();
            try
            {
                if (product == null) product = new Product();

                product.codArticulo = txtCodigo__Nuevo.Text;
                product.Nombre = txtNombre__Nuevo.Text;
                product.Descripcion = txtDescripcion__Nuevo.Text;
                product.Marca = new ComercialBrand();
                string idCommercialBrand = cbMarca_Nuevo.SelectedValue.ToString();
                product.Marca.IdComercialBrand = Convert.ToInt32(idCommercialBrand);
                product.Categoria = new Category();
                string idCategory = cbCategoria_Nuevo.SelectedValue.ToString();
                product.Categoria.IdCategory = Convert.ToInt32(idCategory);
                product.Precio = Convert.ToDecimal(txtPrecio_Nuevo.Text);
                product.urlImagen = txtUrlImagen_Nuevo.Text;

                if (product.Id != 0)
                {
                    CC.editProduct(product);
                    MessageBox.Show("Se ha Modificado con exito");
                    Close();
                }
                else
                {
                    CC.addProduct(product);
                    MessageBox.Show("Se ha cargado el producto con exito");
                    Close();
                }
                

               
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar el producto.");
            }
            


        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            CommerceConnecction CC = new CommerceConnecction();
            DataTable comercialBrands = CC.getConfigFromDB("Marcas");
            DataTable categories = CC.getConfigFromDB("Categorias");

            cbMarca_Nuevo.DataSource = comercialBrands;
            cbMarca_Nuevo.DisplayMember = "descripcion";
            cbMarca_Nuevo.ValueMember = "id";
            cbCategoria_Nuevo.DataSource = categories;
            cbCategoria_Nuevo.DisplayMember = "descripcion";
            cbCategoria_Nuevo.ValueMember = "id";

            if (product != null)
            {
                txtCodigo__Nuevo.Text = product.codArticulo;
                txtCodigo__Nuevo.ReadOnly = true;
                txtNombre__Nuevo.Text = product.Nombre;
                txtDescripcion__Nuevo.Text = product.Descripcion;
                txtUrlImagen_Nuevo.Text = product.urlImagen;
                txtPrecio_Nuevo.Text = product.Precio.ToString() ;
                cbMarca_Nuevo.SelectedValue = product.Marca.IdComercialBrand;
                cbCategoria_Nuevo.SelectedValue = product.Categoria.IdCategory;
            }
          
        }

        private void txtPrecio_Nuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            string point = "";
            TextBox txtBox = (TextBox)sender;
            // only allow one decimal point
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                if ((txtBox.Text.IndexOf('.') > -1) ||
                (txtBox.Text.IndexOf(',') > -1))
                {
                    e.Handled = true;
                }

            }
            
            //int idxPoint = (sender as TextBox).Text.IndexOf(point);
            //if (idxPoint + 3 >= txtBox.Text.Length) e.Handled = true;
            
        }
    }
}
