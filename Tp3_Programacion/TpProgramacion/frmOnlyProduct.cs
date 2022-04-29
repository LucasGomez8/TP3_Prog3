using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using services;
using domain;

namespace TpProgramacion.services
{
    public partial class frmOnlyProduct : Form
    {
        public frmOnlyProduct()
        {
            InitializeComponent();
        }

        private void btnCodigo__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            Product producto = cc.buscarPorCod(txtBCodigo.Text);

            lblR1__only.Text = producto.codArticulo;
            lblR2__only.Text = producto.Nombre;
            lblR4__only.Text = producto.Precio.ToString();
            lblR5__only.Text = producto.Marca.Description;
           

        }

        private void btnNombre__only_Click(object sender, EventArgs e)
        {
            CommerceConnecction cc = new CommerceConnecction();
            Product productobuscado = cc.buscarPorNombre(txtBNombre.Text);
            lblR1__only.Text = productobuscado.codArticulo;
            lblR2__only.Text = productobuscado.Nombre;
            lblR4__only.Text = productobuscado.Precio.ToString();

        }
    }
}
