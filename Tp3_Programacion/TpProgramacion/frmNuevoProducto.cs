using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using domain;
using services;

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

            nuevo.codArticulo = txtCodigo__Nuevo.ToString();
            nuevo.Nombre = txtNombre__Nuevo.ToString();
            nuevo.Descripcion = txtDescripcion__Nuevo.ToString();

            CC.addProduct(nuevo);


        }
    }
}
