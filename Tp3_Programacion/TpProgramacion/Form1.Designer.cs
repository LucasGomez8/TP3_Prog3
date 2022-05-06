
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
            this.btnOnlyProduct = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMuchosProductos = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlNav.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOnlyProduct
            // 
            this.btnOnlyProduct.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOnlyProduct.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnOnlyProduct.Location = new System.Drawing.Point(0, 2);
            this.btnOnlyProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOnlyProduct.Name = "btnOnlyProduct";
            this.btnOnlyProduct.Size = new System.Drawing.Size(200, 98);
            this.btnOnlyProduct.TabIndex = 1;
            this.btnOnlyProduct.Text = "Busqueda por producto";
            this.btnOnlyProduct.UseVisualStyleBackColor = false;
            this.btnOnlyProduct.Click += new System.EventHandler(this.btnOnlyProduct_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.panel4);
            this.pnlNav.Controls.Add(this.panel3);
            this.pnlNav.Controls.Add(this.label1);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(200, 556);
            this.pnlNav.TabIndex = 4;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHome.Controls.Add(this.label2);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(200, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(781, 100);
            this.pnlHome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 100);
            this.label1.TabIndex = 6;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SimSun", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(214, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "H O M E";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMuchosProductos);
            this.panel3.Location = new System.Drawing.Point(0, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnOnlyProduct);
            this.panel4.Location = new System.Drawing.Point(0, 366);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 6;
            // 
            // btnMuchosProductos
            // 
            this.btnMuchosProductos.BackColor = System.Drawing.Color.Black;
            this.btnMuchosProductos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMuchosProductos.Location = new System.Drawing.Point(0, 2);
            this.btnMuchosProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuchosProductos.Name = "btnMuchosProductos";
            this.btnMuchosProductos.Size = new System.Drawing.Size(200, 96);
            this.btnMuchosProductos.TabIndex = 2;
            this.btnMuchosProductos.Text = "Ver todos los productos";
            this.btnMuchosProductos.UseVisualStyleBackColor = false;
            this.btnMuchosProductos.Click += new System.EventHandler(this.btnMuchosProductos_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Image = global::TpProgramacion.Properties.Resources.e00116ec7e1f46b489cf67c002af2743;
            this.lblLogo.Location = new System.Drawing.Point(310, 113);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(578, 390);
            this.lblLogo.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(981, 556);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.lblLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Locos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlNav.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOnlyProduct;
        private System.Windows.Forms.Button btnMuchosProductos;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

