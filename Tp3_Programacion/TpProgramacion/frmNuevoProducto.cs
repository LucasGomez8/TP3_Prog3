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

        public frmNuevoProducto(Product edit)
        {
            InitializeComponent();
            this.product = edit;
            if (product != null)
            {
                Text = "Modificar Producto";
            } 
            else
            {
                Text = "Nuevo Producto";
            }
        }

        private void btnAgregar__Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                prepareRequest();

                if (product.Id != 0)
                    onEdit();
                else
                    onAdd();
               
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar el producto.");
            }

        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            setComboBoxes();
            if (product != null)
                setDataProduct(product);
          
        }

        private void checkInputOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && 
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            //string point = "";
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

        private void setComboBoxes()
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
        }

        private void setDataProduct(Product showProduct)
        {
            txtCodigo__Nuevo.Text = showProduct.codArticulo;
            txtCodigo__Nuevo.ReadOnly = true;
            txtNombre__Nuevo.Text = showProduct.Nombre;
            txtDescripcion__Nuevo.Text = showProduct.Descripcion;
            txtUrlImagen_Nuevo.Text = showProduct.urlImagen;
            txtPrecio_Nuevo.Text = showProduct.Precio.ToString();
            cbMarca_Nuevo.SelectedValue = showProduct.Marca.IdComercialBrand;
            cbCategoria_Nuevo.SelectedValue = showProduct.Categoria.IdCategory;

        }

        private void prepareRequest()
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
        }

        private void onEdit()
        {
            CommerceConnecction CC = new CommerceConnecction();

            if (CC.editProduct(product) != 0)
                MessageBox.Show("Se ha Modificado con exito");
            else
                MessageBox.Show("No se pudo modificar el articulo");

            Close();
        }

        private void onAdd()
        {
            CommerceConnecction CC = new CommerceConnecction();
            
            if (CC.addProduct(product) != 0)
                MessageBox.Show("Se ha agregado el articulo con exito");
            else
                MessageBox.Show("No se pudo modificar el articulo");

            Close();
        }

        private void btnCancelar__Nuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
