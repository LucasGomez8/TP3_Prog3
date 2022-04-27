
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuchosProductos__productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMuchosProductos__productos
            // 
            this.dgvMuchosProductos__productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuchosProductos__productos.Location = new System.Drawing.Point(28, 111);
            this.dgvMuchosProductos__productos.Name = "dgvMuchosProductos__productos";
            this.dgvMuchosProductos__productos.RowHeadersWidth = 51;
            this.dgvMuchosProductos__productos.RowTemplate.Height = 24;
            this.dgvMuchosProductos__productos.Size = new System.Drawing.Size(478, 242);
            this.dgvMuchosProductos__productos.TabIndex = 0;
            // 
            // frmMuchosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.dgvMuchosProductos__productos);
            this.Name = "frmMuchosProductos";
            this.Text = "Todos los productos";
            this.Load += new System.EventHandler(this.frmMuchosProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuchosProductos__productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMuchosProductos__productos;
    }
}