using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpProgramacion.services;
using domain;
using services;

namespace TpProgramacion
{
    public partial class frmMuchosProductos : Form
    {
        public frmMuchosProductos()
        {
            InitializeComponent();
        }

        private void frmMuchosProductos_Load(object sender, EventArgs e)
        {
            CommerceConnecction CC = new CommerceConnecction();
            List<Product> productList = CC.listarProducto();

            foreach (Product product in productList) {
                ListViewItem list = new ListViewItem(product.Nombre);
                list.SubItems.Add(product.Descripcion);
                list.SubItems.Add(product.Marca.Description);
                list.SubItems.Add(product.Precio.ToString());
                listViewProducts.Items.Add(list);
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e) {
            //Product productSelected = (Product)listViewProducts.SelectedItems[0].Tag.ToString();
            
           // if (productSelected != null) {
            //   MessageBox.Show(productSelected.Nombre);
            //}
        }
    }
}
