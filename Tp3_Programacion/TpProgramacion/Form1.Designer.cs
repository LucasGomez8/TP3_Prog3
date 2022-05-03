
namespace TpProgramacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnOnlyProduct = new System.Windows.Forms.Button();
            this.btnMuchosProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(136, 52);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(474, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenidos a Productos Locos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnOnlyProduct
            // 
            this.btnOnlyProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnlyProduct.Location = new System.Drawing.Point(476, 281);
            this.btnOnlyProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnlyProduct.Name = "btnOnlyProduct";
            this.btnOnlyProduct.Size = new System.Drawing.Size(134, 47);
            this.btnOnlyProduct.TabIndex = 1;
            this.btnOnlyProduct.Text = "Busqueda por producto";
            this.btnOnlyProduct.UseVisualStyleBackColor = false;
            this.btnOnlyProduct.Click += new System.EventHandler(this.btnOnlyProduct_Click);
            // 
            // btnMuchosProductos
            // 
            this.btnMuchosProductos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMuchosProductos.Location = new System.Drawing.Point(143, 281);
            this.btnMuchosProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuchosProductos.Name = "btnMuchosProductos";
            this.btnMuchosProductos.Size = new System.Drawing.Size(134, 47);
            this.btnMuchosProductos.TabIndex = 2;
            this.btnMuchosProductos.Text = "Ver todos los productos";
            this.btnMuchosProductos.UseVisualStyleBackColor = false;
            this.btnMuchosProductos.Click += new System.EventHandler(this.btnMuchosProductos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 452);
            this.Controls.Add(this.btnMuchosProductos);
            this.Controls.Add(this.btnOnlyProduct);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "Productos Locos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnOnlyProduct;
        private System.Windows.Forms.Button btnMuchosProductos;
    }
}

