using services;
using System;
using System.Windows.Forms;
using TpProgramacion.services;

namespace TpProgramacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CommerceConnecction datos = new CommerceConnecction();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnOnlyProduct_Click(object sender, EventArgs e)
        {
            frmOnlyProduct onlyp = new frmOnlyProduct();
            onlyp.ShowDialog();
        }

        private void btnMuchosProductos_Click(object sender, EventArgs e)
        {
            frmMuchosProductos muchop = new frmMuchosProductos();
            muchop.ShowDialog();
        }
    }
}
