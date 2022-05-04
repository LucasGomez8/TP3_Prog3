using domain;
using services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TpProgramacion.services;

namespace TpProgramacion
{
    public partial class frmMuchosProductos : Form
    {

        private List<Product> productlist;

        Product select;

        public frmMuchosProductos()
        {
            InitializeComponent();
        }

        private void frmMuchosProductos_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            CommerceConnecction cc = new CommerceConnecction();
            try
            {
                productlist = cc.listarProducto();
                dvgTodosLosProductos.DataSource = productlist;
                dvgTodosLosProductos.Columns["UrlImagen"].Visible = false;
                dvgTodosLosProductos.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar el listado de articulos.", "Te pedimos disculpas");
            }
        }
        
        public void imageLoad(string img)
        {
            try
            {
                pbxTodos.Load(img);
            }
            catch (Exception)
            {
                pbxTodos.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/1024px-No_image_available.svg.png");
            }
            
        }

        private void dvgTodosLosProductos_SelectionChanged(object sender, EventArgs e)
        {
            select = (Product)dvgTodosLosProductos.CurrentRow.DataBoundItem;
            imageLoad(select.urlImagen);
        }

        private void btnAgregar_Todos_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevop = new frmNuevoProducto();
            nuevop.ShowDialog();
            load();
        }

        private void btnEditar__Todos_Click(object sender, EventArgs e)
        {
            frmNuevoProducto edit = new frmNuevoProducto(select);
            edit.ShowDialog();
            load();
        }

        private void btnBorrar__Todos_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            try
            {
                DialogResult response = MessageBox.Show("¿Realmente quiere eliminar el producto?", 
                    "Eliminar Producto", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning);

                if (response==DialogResult.Yes)
                {
                    if (cc.deleteProduct(select.codArticulo) > 0)
                    {
                        MessageBox.Show("Eliminado Exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al eliminar");
                    }
                }
                
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnVerDetalle__Todos_Click(object sender, EventArgs e)
        {
            frmOnlyProduct onlyp = new frmOnlyProduct(select);
            onlyp.ShowDialog();
            load();
        }
    }
}
