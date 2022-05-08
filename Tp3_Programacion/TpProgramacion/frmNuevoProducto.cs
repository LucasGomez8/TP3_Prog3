using domain;
using services;
using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace TpProgramacion
{
    public partial class frmNuevoProducto : Form
    {

        private Product product = null;
        private OpenFileDialog imageLoad = null;
        
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
                if (!checkAllImputs())
                {
                    MessageBox.Show("Faltan datos necesario en el formulario para completar la tarea", "Revise los datos ingresados");
                    return;
                }
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
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            TextBox txtBox = (TextBox)sender;
            // only allow one decimal point
            if ((e.KeyChar == '.'))
            {
                if ((txtBox.Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }

            // only allow two decimals number
            int idxPoint = (sender as TextBox).Text.IndexOf(".");
            if (idxPoint != -1 && !(e.KeyChar == (char)Keys.Back))
            {
                if (txtBox.Text.Length - idxPoint >= 3)
                {
                    e.Handled = true;
                }
            }
            
        }

        private void setComboBoxes()
        {
            CommerceConnecction CC = new CommerceConnecction();
            DataTable comercialBrands = CC.getConfigFromDB("Marcas");
            DataTable categories = CC.getConfigFromDB("Categorias");

            if (comercialBrands != null)
            { 
                DataRow none = comercialBrands.NewRow();
                none["id"] = 0;
                none["descripcion"] = "";
                comercialBrands.Rows.InsertAt(none, 0);
                cbMarca_Nuevo.DataSource = comercialBrands;
                cbMarca_Nuevo.DisplayMember = "descripcion";
                cbMarca_Nuevo.ValueMember = "id";
            }
            if (categories != null)
            {
                DataRow none = categories.NewRow();
                none["id"] = 0;
                none["descripcion"] = "";
                categories.Rows.InsertAt(none, 0);
                cbCategoria_Nuevo.DataSource = categories;
                cbCategoria_Nuevo.DisplayMember = "descripcion";
                cbCategoria_Nuevo.ValueMember = "id";
            }
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
            if (imageLoad != null) product.urlImagen = ConfigurationManager.AppSettings["images-folder"] + imageLoad.SafeFileName;
            else product.urlImagen = txtUrlImagen_Nuevo.Text;
        }


        private void onEdit()
        {
            CommerceConnecction CC = new CommerceConnecction();

            if (CC.editProduct(product) != 0) {
                MessageBox.Show("Se ha Modificado con exito");
                if (imageLoad != null && !txtUrlImagen_Nuevo.Text.ToUpper().Contains("HTTP"))
                {
                    checkAndCreateFolder();

                    File.Copy(imageLoad.FileName, ConfigurationManager.AppSettings["images-folder"] + imageLoad.SafeFileName, true);
                } 
            }
            else
                MessageBox.Show("No se pudo modificar el articulo");

            Close();
        }

        private void onAdd()
        {
            CommerceConnecction CC = new CommerceConnecction();
            //CC.addProduct(product);
            if (CC.addProduct(product) != 0)
            {
                MessageBox.Show("Se ha agregado el articulo con exito");
                if (imageLoad != null && !txtUrlImagen_Nuevo.Text.ToUpper().Contains("HTTP"))
                {
                    checkAndCreateFolder();

                    File.Copy(imageLoad.FileName, ConfigurationManager.AppSettings["images-folder"] + imageLoad.SafeFileName, true);
                }
            }
            else
                MessageBox.Show("No se pudo Agregar el articulo");

            Close();
        }

        private void btnCancelar__Nuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_LocalImage_Click(object sender, EventArgs e)
        {
            imageLoad = new OpenFileDialog();
            imageLoad.Filter = "jpg|*.jpg;|png|*.png";

            if (imageLoad.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen_Nuevo.Text = imageLoad.FileName;
            }

        }

        private void checkAndCreateFolder()
        {
            string folder = ConfigurationManager.AppSettings["images-folder"];
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }
    
        private bool checkAllImputs()
        {
            if (txtCodigo__Nuevo.Text.Length == 0) return false;
            if (txtNombre__Nuevo.Text.Length == 0) return false;
            if (txtDescripcion__Nuevo.Text.Length == 0) return false;
            if (txtPrecio_Nuevo.Text.Length == 0) return false;
            if (cbMarca_Nuevo.SelectedIndex == 0) return false;
            if (cbCategoria_Nuevo.SelectedIndex == 0) return false;

            return true;
        }    
    }
}
