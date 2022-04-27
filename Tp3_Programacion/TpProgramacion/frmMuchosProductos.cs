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
            dgvMuchosProductos__productos.DataSource = CC.listarProducto();
        }
    }
}
