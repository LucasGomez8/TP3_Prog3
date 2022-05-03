using domain;
using services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TpProgramacion
{
    public partial class frmMuchosProductos : Form
    {

        private List<Product> productlist;
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
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dvgTodosLosProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            Product select = (Product)dvgTodosLosProductos.CurrentRow.DataBoundItem;
            imageLoad(select.urlImagen);
        }
    }
}
