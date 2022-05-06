using domain;
using services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TpProgramacion.services;

namespace TpProgramacion
{
    public partial class frmMuchosProductos : Form
    {

        private List<Product> productlist;

        private int filtroBrand = 0;
        private int filtroCategory = 0;
        private int filtroOrder = 0;

        private Product productSelected;

        public frmMuchosProductos()
        {
            InitializeComponent();
        }

        private void frmMuchosProductos_Load(object sender, EventArgs e)
        {
            setComboBoxes();
            load();
        }

        public void load()
        {
            CommerceConnecction cc = new CommerceConnecction();
            try
            {
                productlist = cc.listarProducto();
                setup();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar el listado de articulos.", 
                    "Te pedimos disculpas");
            }
        }

        private void aplicarFilters()
        {
            List<Product> filter = new List<Product>();

            if (filtroBrand == 0 && filtroCategory == 0)
            {
                load();
                return;
            }

            foreach (Product items in productlist)
            {
                if (items.Marca.IdComercialBrand != filtroBrand && filtroBrand != 0)
                {
                    continue;
                }
                if (items.Categoria.IdCategory != filtroCategory && filtroCategory != 0)
                {
                    continue;
                }
                filter.Add(items);
            }

            orderList(filter);
            dvgTodosLosProductos.DataSource = filter;
        }

        private void setup()
        {
            orderList(productlist);
            dvgTodosLosProductos.DataSource = productlist;
            dvgTodosLosProductos.Refresh();
            dvgTodosLosProductos.Columns["UrlImagen"].Visible = false;
            dvgTodosLosProductos.Columns["Id"].Visible = false;
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
                none["descripcion"] = "Todos";
                comercialBrands.Rows.InsertAt(none, 0);

                cboMarca__Todos.DataSource = comercialBrands;
                cboMarca__Todos.DisplayMember = "descripcion";
                cboMarca__Todos.ValueMember = "id";
                
            }
            if (categories != null)
            {
                DataRow none = categories.NewRow();
                none["id"] = 0;
                none["descripcion"] = "Todos";
                categories.Rows.InsertAt(none, 0);

                cboCategoria__Todos.DataSource = categories;
                cboCategoria__Todos.DisplayMember = "descripcion";
                cboCategoria__Todos.ValueMember = "id";
            }

            List<string> priceOrder = new List<string>();
            priceOrder.Add("Sin Especificar");
            priceOrder.Add("Ascendente");
            priceOrder.Add("Descendente");
            cboOrdenPrice__Todos.DataSource = priceOrder;
        }

        private void orderList(List<Product> listToOrder)
        {

            if (listToOrder == null) return;
            
            switch (filtroOrder)
            {
                case 1:
                    for (int i = 0; i < listToOrder.Count; i++)
                    {
                        for (int x = 0; x < listToOrder.Count; x++)
                        {
                            if (listToOrder[i].Precio < listToOrder[x].Precio)
                            {
                                Product aux = listToOrder[i];
                                listToOrder[i] = listToOrder[x];
                                listToOrder[x] = aux;
                            }
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < listToOrder.Count; i++)
                    {
                        for (int x = 0; x < listToOrder.Count; x++)
                        {
                            if (listToOrder[i].Precio > listToOrder[x].Precio)
                            {
                                Product aux = listToOrder[i];
                                listToOrder[i] = listToOrder[x];
                                listToOrder[x] = aux;
                            }
                        }
                    }
                    break;
                default:
                    return;
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
                pbxTodos.Image = Properties.Resources.image_default;
            }
            
        }

        private void dvgTodosLosProductos_SelectionChanged(object sender, EventArgs e)
        {
            productSelected = (Product)dvgTodosLosProductos.CurrentRow.DataBoundItem;
            imageLoad(productSelected.urlImagen);
        }

        private void btnAgregar_Todos_Click(object sender, EventArgs e)
        {
            frmNuevoProducto nuevop = new frmNuevoProducto(null);
            nuevop.ShowDialog();
            load();
        }

        private void btnEditar__Todos_Click(object sender, EventArgs e)
        {
            frmNuevoProducto edit = new frmNuevoProducto(productSelected);
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
                    if (cc.deleteProduct(productSelected.codArticulo) > 0)
                    {
                        MessageBox.Show("Eliminado Exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo borrar el articulo");
                    }
                }
                
                load();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al eliminar el articulo");
            }

        }

        private void btnVerDetalle__Todos_Click(object sender, EventArgs e)
        {
            frmOnlyProduct onlyp = new frmOnlyProduct(productSelected);
            onlyp.ShowDialog();
            load();
        }

        private void cboOrdenPrice__Todos_DropDownClosed(object sender, EventArgs e)
        {
            filtroOrder = cboOrdenPrice__Todos.SelectedIndex;
            aplicarFilters();
        }

        private void cboMarca__Todos_DropDownClosed(object sender, EventArgs e)
        {
            filtroBrand = cboMarca__Todos.SelectedIndex;
            aplicarFilters();
        }

        private void cboCategoria__Todos_DropDownClosed(object sender, EventArgs e)
        {
            filtroCategory = cboCategoria__Todos.SelectedIndex;
            aplicarFilters();
        }
    }
}
