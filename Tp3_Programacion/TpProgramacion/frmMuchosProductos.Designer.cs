
namespace TpProgramacion
{
    partial class frmMuchosProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMuchosProductos__productos = new System.Windows.Forms.DataGridView();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.ColumNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuchosProductos__productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuchosProductos__productos
            // 
            this.dgvMuchosProductos__productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuchosProductos__productos.Location = new System.Drawing.Point(36, 203);
            this.dgvMuchosProductos__productos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMuchosProductos__productos.Name = "dgvMuchosProductos__productos";
            this.dgvMuchosProductos__productos.RowHeadersWidth = 51;
            this.dgvMuchosProductos__productos.RowTemplate.Height = 24;
            this.dgvMuchosProductos__productos.Size = new System.Drawing.Size(358, 197);
            this.dgvMuchosProductos__productos.TabIndex = 0;
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumNombre,
            this.ColumDescripcion,
            this.ColumMarca,
            this.ColumPrecio});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(36, 12);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(563, 164);
            this.listViewProducts.TabIndex = 1;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.SelectedIndexChanged += new System.EventHandler(this.listViewProducts_SelectedIndexChanged);
            // 
            // ColumNombre
            // 
            this.ColumNombre.Text = "Nombre";
            this.ColumNombre.Width = 107;
            // 
            // ColumDescripcion
            // 
            this.ColumDescripcion.Text = "Descripcion";
            this.ColumDescripcion.Width = 90;
            // 
            // ColumMarca
            // 
            this.ColumMarca.Text = "Marca";
            this.ColumMarca.Width = 103;
            // 
            // ColumPrecio
            // 
            this.ColumPrecio.Text = "Precio";
            this.ColumPrecio.Width = 145;
            // 
            // frmMuchosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 431);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.dgvMuchosProductos__productos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMuchosProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos los productos";
            this.Load += new System.EventHandler(this.frmMuchosProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuchosProductos__productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuchosProductos__productos;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader ColumNombre;
        private System.Windows.Forms.ColumnHeader ColumDescripcion;
        private System.Windows.Forms.ColumnHeader ColumMarca;
        private System.Windows.Forms.ColumnHeader ColumPrecio;
    }
}