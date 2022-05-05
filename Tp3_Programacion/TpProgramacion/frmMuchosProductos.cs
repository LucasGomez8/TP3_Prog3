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
            load();
        }

        public void load()
        {
            CommerceConnecction cc = new CommerceConnecction();
            try
            {
                setComboBoxes();
                productlist = cc.listarProducto();
                setup();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar el listado de articulos.", 
                    "Te pedimos disculpas");
            }
        }

        private void filterLoad(int e, bool itsBrand)
        {

            List<Product> filter = new List<Product>();

            foreach (Product items in productlist)
            {
                if (itsBrand)
                {
                    if (items.Marca.IdComercialBrand == e)
                    {
                        filter.Add(items);
                    }
                }
                else
                {
                    if (items.Categoria.IdCategory == e)
                    {
                        filter.Add(items);
                    }
                }    
            }

            dvgTodosLosProductos.DataSource = filter;
        }

        private void aplicarFilters()
        {
            List<Product> filter = new List<Product>();

            foreach (Product items in productlist)
            {
                if (items.Marca.IdComercialBrand == filtroBrand || filtroBrand == 0)
                {
                    if (!filter.Contains(items))
                    {
                        filter.Add(items);
                    }
                }
                if (items.Categoria.IdCategory == filtroCategory || filtroCategory == 0)
                {
                    if (!filter.Contains(items))
                    {
                        filter.Add(items);
                    }
                }
            }

            dvgTodosLosProductos.DataSource = filter;
        }

        private void setup()
        {
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
                cboMarca__Todos.DataSource = comercialBrands;
                cboMarca__Todos.DisplayMember = "descripcion";
                cboMarca__Todos.ValueMember = "id";
                
            }
            if (categories != null)
            {
                cboCategoria__Todos.DataSource = categories;
                cboCategoria__Todos.DisplayMember = "descripcion";
                cboCategoria__Todos.ValueMember = "id";
            }

            List<string> priceOrder = new List<string>();
            priceOrder.Add(" ");
            priceOrder.Add("Ascendente");
            priceOrder.Add("Descendente");
            cboOrdenPrice__Todos.DataSource = priceOrder;
        }

        private void orderList(bool asc)
        {
            if (asc)
            {
                for (int i = 0; i < productlist.Count; i++)
                {
                    for (int x = 0; x < productlist.Count; x++)
                    {
                        if (productlist[i].Precio < productlist[x].Precio)
                        {
                            Product aux = productlist[i];
                            productlist[i] = productlist[x];
                            productlist[x] = aux;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < productlist.Count; i++)
                {
                    for (int x = 0; x < productlist.Count; x++)
                    {
                        if (productlist[i].Precio > productlist[x].Precio)
                        {
                            Product aux = productlist[i];
                            productlist[i] = productlist[x];
                            productlist[x] = aux;
                        }
                    }
                }
            }
            
            setup();
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
            int orderSelected = cboOrdenPrice__Todos.SelectedIndex;

            if (orderSelected == 0)
            {
                orderList(true);
            }
            else
            {
                orderList(false);
            }
        }

        private void cboMarca__Todos_DropDownClosed(object sender, EventArgs e)
        {
            filtroBrand = cboMarca__Todos.SelectedIndex;
            aplicarFilters();
           /* 
            if(brandSelected == 0)
            {
                load();
            }
            else
            {
                filterLoad(brandSelected,true);
            }*/
        }

        private void cboCategoria__Todos_DropDownClosed(object sender, EventArgs e)
        {
            filtroCategory = cboCategoria__Todos.SelectedIndex;
            aplicarFilters();
            /*
            if(categorySelected == 0)
            {
                load();
            }
            else
            {
                filterLoad(categorySelected,false);
            }*/
        }
    }
}
