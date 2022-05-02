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
        }

        public frmNuevoProducto(Product edit)
        {
            InitializeComponent();
            this.product = edit;
        }

        private void btnAgregar__Nuevo_Click(object sender, EventArgs e)
        {
            Product nuevo = new Product();
            CommerceConnecction CC = new CommerceConnecction();

            nuevo.codArticulo = txtCodigo__Nuevo.Text;
            nuevo.Nombre = txtNombre__Nuevo.Text;
            nuevo.Descripcion = txtDescripcion__Nuevo.Text;
            nuevo.Marca = new ComercialBrand();
            string idCommercialBrand = cbMarca_Nuevo.SelectedValue.ToString();
            nuevo.Marca.IdComercialBrand = Convert.ToInt32(idCommercialBrand);
            nuevo.Categoria = new Category();
            string idCategory = cbCategoria_Nuevo.SelectedValue.ToString();
            nuevo.Categoria.IdCategory = Convert.ToInt32(idCategory);
            nuevo.Precio = Convert.ToDecimal(txtPrecio_Nuevo.Text);
            nuevo.urlImagen = txtUrlImagen_Nuevo.Text;
            CC.addProduct(nuevo);


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
                txtNombre__Nuevo.Text = product.Nombre;
                txtDescripcion__Nuevo.Text = product.Descripcion;
                txtUrlImagen_Nuevo.Text = product.urlImagen;
                cbMarca_Nuevo.SelectedValue = product.Marca.Id;
            }
          
        }
    }
}
