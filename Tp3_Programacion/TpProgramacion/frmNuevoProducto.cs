using domain;
using services;
using System;
using System.Data;
using System.Windows.Forms;

namespace TpProgramacion
{
    public partial class frmNuevoProducto : Form
    {
        public frmNuevoProducto()
        {
            InitializeComponent();
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
        }

        private void cbMarca_Nuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = cbMarca_Nuevo.SelectedValue;
            testId1.Text = value.ToString();
        }

        private void cbCategoria_Nuevo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = cbCategoria_Nuevo.SelectedValue;
            testId2.Text = value.ToString();
        }
    }
}
