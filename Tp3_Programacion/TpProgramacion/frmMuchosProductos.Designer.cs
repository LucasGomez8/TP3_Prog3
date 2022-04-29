
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
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.ColumNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMarca__muchos = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumNombre,
            this.ColumDescripcion,
            this.ColumMarca,
            this.ColumPrecio});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(12, 12);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(470, 199);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lblMarca__muchos
            // 
            this.lblMarca__muchos.AutoSize = true;
            this.lblMarca__muchos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca__muchos.Location = new System.Drawing.Point(12, 247);
            this.lblMarca__muchos.Name = "lblMarca__muchos";
            this.lblMarca__muchos.Size = new System.Drawing.Size(105, 16);
            this.lblMarca__muchos.TabIndex = 3;
            this.lblMarca__muchos.Text = "Filtrar por Marca";
            // 
            // frmMuchosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 431);
            this.Controls.Add(this.lblMarca__muchos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listViewProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMuchosProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos los productos";
            this.Load += new System.EventHandler(this.frmMuchosProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader ColumNombre;
        private System.Windows.Forms.ColumnHeader ColumDescripcion;
        private System.Windows.Forms.ColumnHeader ColumMarca;
        private System.Windows.Forms.ColumnHeader ColumPrecio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMarca__muchos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}