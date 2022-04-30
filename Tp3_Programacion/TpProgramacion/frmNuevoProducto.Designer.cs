
namespace TpProgramacion
{
    partial class frmNuevoProducto
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
            this.lblCodArticulo__Nuevo = new System.Windows.Forms.Label();
            this.txtCodigo__Nuevo = new System.Windows.Forms.TextBox();
            this.txtNombre__Nuevo = new System.Windows.Forms.TextBox();
            this.lblNombre__Nuevo = new System.Windows.Forms.Label();
            this.txtDescripcion__Nuevo = new System.Windows.Forms.TextBox();
            this.lblDescripcion__Nuevo = new System.Windows.Forms.Label();
            this.btnAgregar__Nuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodArticulo__Nuevo
            // 
            this.lblCodArticulo__Nuevo.AutoSize = true;
            this.lblCodArticulo__Nuevo.Location = new System.Drawing.Point(45, 41);
            this.lblCodArticulo__Nuevo.Name = "lblCodArticulo__Nuevo";
            this.lblCodArticulo__Nuevo.Size = new System.Drawing.Size(81, 13);
            this.lblCodArticulo__Nuevo.TabIndex = 0;
            this.lblCodArticulo__Nuevo.Text = "Codigo Articulo:";
            // 
            // txtCodigo__Nuevo
            // 
            this.txtCodigo__Nuevo.Location = new System.Drawing.Point(132, 38);
            this.txtCodigo__Nuevo.Name = "txtCodigo__Nuevo";
            this.txtCodigo__Nuevo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo__Nuevo.TabIndex = 1;
            // 
            // txtNombre__Nuevo
            // 
            this.txtNombre__Nuevo.Location = new System.Drawing.Point(132, 82);
            this.txtNombre__Nuevo.Name = "txtNombre__Nuevo";
            this.txtNombre__Nuevo.Size = new System.Drawing.Size(100, 20);
            this.txtNombre__Nuevo.TabIndex = 9;
            // 
            // lblNombre__Nuevo
            // 
            this.lblNombre__Nuevo.AutoSize = true;
            this.lblNombre__Nuevo.Location = new System.Drawing.Point(79, 85);
            this.lblNombre__Nuevo.Name = "lblNombre__Nuevo";
            this.lblNombre__Nuevo.Size = new System.Drawing.Size(47, 13);
            this.lblNombre__Nuevo.TabIndex = 8;
            this.lblNombre__Nuevo.Text = "Nombre:";
            // 
            // txtDescripcion__Nuevo
            // 
            this.txtDescripcion__Nuevo.Location = new System.Drawing.Point(132, 124);
            this.txtDescripcion__Nuevo.Name = "txtDescripcion__Nuevo";
            this.txtDescripcion__Nuevo.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion__Nuevo.TabIndex = 11;
            // 
            // lblDescripcion__Nuevo
            // 
            this.lblDescripcion__Nuevo.AutoSize = true;
            this.lblDescripcion__Nuevo.Location = new System.Drawing.Point(63, 127);
            this.lblDescripcion__Nuevo.Name = "lblDescripcion__Nuevo";
            this.lblDescripcion__Nuevo.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion__Nuevo.TabIndex = 10;
            this.lblDescripcion__Nuevo.Text = "Descripcion";
            // 
            // btnAgregar__Nuevo
            // 
            this.btnAgregar__Nuevo.Location = new System.Drawing.Point(82, 177);
            this.btnAgregar__Nuevo.Name = "btnAgregar__Nuevo";
            this.btnAgregar__Nuevo.Size = new System.Drawing.Size(128, 37);
            this.btnAgregar__Nuevo.TabIndex = 12;
            this.btnAgregar__Nuevo.Text = "Agregar";
            this.btnAgregar__Nuevo.UseVisualStyleBackColor = true;
            this.btnAgregar__Nuevo.Click += new System.EventHandler(this.btnAgregar__Nuevo_Click);
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 495);
            this.Controls.Add(this.btnAgregar__Nuevo);
            this.Controls.Add(this.txtDescripcion__Nuevo);
            this.Controls.Add(this.lblDescripcion__Nuevo);
            this.Controls.Add(this.txtNombre__Nuevo);
            this.Controls.Add(this.lblNombre__Nuevo);
            this.Controls.Add(this.txtCodigo__Nuevo);
            this.Controls.Add(this.lblCodArticulo__Nuevo);
            this.Name = "frmNuevoProducto";
            this.Text = "frmNuevoProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodArticulo__Nuevo;
        private System.Windows.Forms.TextBox txtCodigo__Nuevo;
        private System.Windows.Forms.TextBox txtNombre__Nuevo;
        private System.Windows.Forms.Label lblNombre__Nuevo;
        private System.Windows.Forms.TextBox txtDescripcion__Nuevo;
        private System.Windows.Forms.Label lblDescripcion__Nuevo;
        private System.Windows.Forms.Button btnAgregar__Nuevo;
    }
}