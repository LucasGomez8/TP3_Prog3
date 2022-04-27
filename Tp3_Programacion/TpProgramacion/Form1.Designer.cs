
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
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Variable Display", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(182, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(632, 49);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenidos a Productos Locos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnOnlyProduct
            // 
            this.btnOnlyProduct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOnlyProduct.Location = new System.Drawing.Point(574, 249);
            this.btnOnlyProduct.Name = "btnOnlyProduct";
            this.btnOnlyProduct.Size = new System.Drawing.Size(178, 58);
            this.btnOnlyProduct.TabIndex = 1;
            this.btnOnlyProduct.Text = "Clickame perroooou";
            this.btnOnlyProduct.UseVisualStyleBackColor = false;
            this.btnOnlyProduct.Click += new System.EventHandler(this.btnOnlyProduct_Click);
            // 
            // btnMuchosProductos
            // 
            this.btnMuchosProductos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMuchosProductos.Location = new System.Drawing.Point(231, 249);
            this.btnMuchosProductos.Name = "btnMuchosProductos";
            this.btnMuchosProductos.Size = new System.Drawing.Size(178, 58);
            this.btnMuchosProductos.TabIndex = 2;
            this.btnMuchosProductos.Text = "Clickacho aca";
            this.btnMuchosProductos.UseVisualStyleBackColor = false;
            this.btnMuchosProductos.Click += new System.EventHandler(this.btnMuchosProductos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 556);
            this.Controls.Add(this.btnMuchosProductos);
            this.Controls.Add(this.btnOnlyProduct);
            this.Controls.Add(this.lblTitulo);
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

