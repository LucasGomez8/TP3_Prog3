using helpers;

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
            this.lblMarca_Nuevo = new System.Windows.Forms.Label();
            this.cbMarca_Nuevo = new System.Windows.Forms.ComboBox();
            this.lblCategoria_nuevo = new System.Windows.Forms.Label();
            this.cbCategoria_Nuevo = new System.Windows.Forms.ComboBox();
            this.txtPrecio_Nuevo = new System.Windows.Forms.TextBox();
            this.lblPrecio_Nuevo = new System.Windows.Forms.Label();
            this.txtUrlImagen_Nuevo = new System.Windows.Forms.TextBox();
            this.lblUrlImage_Nuevo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd_LocalImage = new System.Windows.Forms.Button();
            this.btnCancelar__Nuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodArticulo__Nuevo
            // 
            this.lblCodArticulo__Nuevo.AutoSize = true;
            this.lblCodArticulo__Nuevo.Location = new System.Drawing.Point(8, 30);
            this.lblCodArticulo__Nuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodArticulo__Nuevo.Name = "lblCodArticulo__Nuevo";
            this.lblCodArticulo__Nuevo.Size = new System.Drawing.Size(107, 17);
            this.lblCodArticulo__Nuevo.TabIndex = 0;
            this.lblCodArticulo__Nuevo.Text = "Codigo Articulo:";
            // 
            // txtCodigo__Nuevo
            // 
            this.txtCodigo__Nuevo.Location = new System.Drawing.Point(140, 22);
            this.txtCodigo__Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo__Nuevo.Name = "txtCodigo__Nuevo";
            this.txtCodigo__Nuevo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo__Nuevo.TabIndex = 1;
            // 
            // txtNombre__Nuevo
            // 
            this.txtNombre__Nuevo.Location = new System.Drawing.Point(140, 66);
            this.txtNombre__Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre__Nuevo.Name = "txtNombre__Nuevo";
            this.txtNombre__Nuevo.Size = new System.Drawing.Size(132, 22);
            this.txtNombre__Nuevo.TabIndex = 9;
            // 
            // lblNombre__Nuevo
            // 
            this.lblNombre__Nuevo.AutoSize = true;
            this.lblNombre__Nuevo.Location = new System.Drawing.Point(8, 74);
            this.lblNombre__Nuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre__Nuevo.Name = "lblNombre__Nuevo";
            this.lblNombre__Nuevo.Size = new System.Drawing.Size(62, 17);
            this.lblNombre__Nuevo.TabIndex = 8;
            this.lblNombre__Nuevo.Text = "Nombre:";
            // 
            // txtDescripcion__Nuevo
            // 
            this.txtDescripcion__Nuevo.Location = new System.Drawing.Point(140, 108);
            this.txtDescripcion__Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion__Nuevo.Name = "txtDescripcion__Nuevo";
            this.txtDescripcion__Nuevo.Size = new System.Drawing.Size(132, 22);
            this.txtDescripcion__Nuevo.TabIndex = 11;
            // 
            // lblDescripcion__Nuevo
            // 
            this.lblDescripcion__Nuevo.AutoSize = true;
            this.lblDescripcion__Nuevo.Location = new System.Drawing.Point(8, 117);
            this.lblDescripcion__Nuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion__Nuevo.Name = "lblDescripcion__Nuevo";
            this.lblDescripcion__Nuevo.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion__Nuevo.TabIndex = 10;
            this.lblDescripcion__Nuevo.Text = "Descripcion:";
            // 
            // btnAgregar__Nuevo
            // 
            this.btnAgregar__Nuevo.BackColor = System.Drawing.Color.White;
            this.btnAgregar__Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar__Nuevo.Location = new System.Drawing.Point(93, 406);
            this.btnAgregar__Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar__Nuevo.Name = "btnAgregar__Nuevo";
            this.btnAgregar__Nuevo.Size = new System.Drawing.Size(142, 39);
            this.btnAgregar__Nuevo.TabIndex = 12;
            this.btnAgregar__Nuevo.Text = "Aceptar";
            this.btnAgregar__Nuevo.UseVisualStyleBackColor = false;
            this.btnAgregar__Nuevo.Click += new System.EventHandler(this.btnAgregar__Nuevo_Click);
            // 
            // lblMarca_Nuevo
            // 
            this.lblMarca_Nuevo.AutoSize = true;
            this.lblMarca_Nuevo.Location = new System.Drawing.Point(8, 160);
            this.lblMarca_Nuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca_Nuevo.Name = "lblMarca_Nuevo";
            this.lblMarca_Nuevo.Size = new System.Drawing.Size(51, 17);
            this.lblMarca_Nuevo.TabIndex = 13;
            this.lblMarca_Nuevo.Text = "Marca:";
            // 
            // cbMarca_Nuevo
            // 
            this.cbMarca_Nuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca_Nuevo.FormattingEnabled = true;
            this.cbMarca_Nuevo.Location = new System.Drawing.Point(140, 150);
            this.cbMarca_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMarca_Nuevo.Name = "cbMarca_Nuevo";
            this.cbMarca_Nuevo.Size = new System.Drawing.Size(132, 24);
            this.cbMarca_Nuevo.TabIndex = 14;
            this.cbMarca_Nuevo.TabStop = false;
            // 
            // lblCategoria_nuevo
            // 
            this.lblCategoria_nuevo.AutoSize = true;
            this.lblCategoria_nuevo.Location = new System.Drawing.Point(8, 203);
            this.lblCategoria_nuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria_nuevo.Name = "lblCategoria_nuevo";
            this.lblCategoria_nuevo.Size = new System.Drawing.Size(73, 17);
            this.lblCategoria_nuevo.TabIndex = 17;
            this.lblCategoria_nuevo.Text = "Categoria:";
            // 
            // cbCategoria_Nuevo
            // 
            this.cbCategoria_Nuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria_Nuevo.FormattingEnabled = true;
            this.cbCategoria_Nuevo.Location = new System.Drawing.Point(140, 194);
            this.cbCategoria_Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria_Nuevo.Name = "cbCategoria_Nuevo";
            this.cbCategoria_Nuevo.Size = new System.Drawing.Size(132, 24);
            this.cbCategoria_Nuevo.TabIndex = 18;
            // 
            // txtPrecio_Nuevo
            // 
            this.txtPrecio_Nuevo.Location = new System.Drawing.Point(140, 238);
            this.txtPrecio_Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio_Nuevo.Name = "txtPrecio_Nuevo";
            this.txtPrecio_Nuevo.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio_Nuevo.TabIndex = 20;
            this.txtPrecio_Nuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumberHelper.inputOnlyNumberWithDeicmals);
            // 
            // lblPrecio_Nuevo
            // 
            this.lblPrecio_Nuevo.AutoSize = true;
            this.lblPrecio_Nuevo.Location = new System.Drawing.Point(8, 246);
            this.lblPrecio_Nuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio_Nuevo.Name = "lblPrecio_Nuevo";
            this.lblPrecio_Nuevo.Size = new System.Drawing.Size(48, 17);
            this.lblPrecio_Nuevo.TabIndex = 19;
            this.lblPrecio_Nuevo.Text = "Precio";
            // 
            // txtUrlImagen_Nuevo
            // 
            this.txtUrlImagen_Nuevo.Location = new System.Drawing.Point(140, 281);
            this.txtUrlImagen_Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrlImagen_Nuevo.Name = "txtUrlImagen_Nuevo";
            this.txtUrlImagen_Nuevo.Size = new System.Drawing.Size(132, 22);
            this.txtUrlImagen_Nuevo.TabIndex = 22;
            // 
            // lblUrlImage_Nuevo
            // 
            this.lblUrlImage_Nuevo.AutoSize = true;
            this.lblUrlImage_Nuevo.Location = new System.Drawing.Point(8, 290);
            this.lblUrlImage_Nuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlImage_Nuevo.Name = "lblUrlImage_Nuevo";
            this.lblUrlImage_Nuevo.Size = new System.Drawing.Size(106, 17);
            this.lblUrlImage_Nuevo.TabIndex = 21;
            this.lblUrlImage_Nuevo.Text = "URL de Imagen";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnAdd_LocalImage);
            this.groupBox1.Controls.Add(this.lblCodArticulo__Nuevo);
            this.groupBox1.Controls.Add(this.lblNombre__Nuevo);
            this.groupBox1.Controls.Add(this.txtUrlImagen_Nuevo);
            this.groupBox1.Controls.Add(this.lblDescripcion__Nuevo);
            this.groupBox1.Controls.Add(this.txtPrecio_Nuevo);
            this.groupBox1.Controls.Add(this.lblUrlImage_Nuevo);
            this.groupBox1.Controls.Add(this.cbCategoria_Nuevo);
            this.groupBox1.Controls.Add(this.lblMarca_Nuevo);
            this.groupBox1.Controls.Add(this.cbMarca_Nuevo);
            this.groupBox1.Controls.Add(this.lblCategoria_nuevo);
            this.groupBox1.Controls.Add(this.lblPrecio_Nuevo);
            this.groupBox1.Controls.Add(this.txtDescripcion__Nuevo);
            this.groupBox1.Controls.Add(this.txtCodigo__Nuevo);
            this.groupBox1.Controls.Add(this.txtNombre__Nuevo);
            this.groupBox1.Location = new System.Drawing.Point(93, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(316, 336);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd_LocalImage
            // 
            this.btnAdd_LocalImage.Location = new System.Drawing.Point(279, 281);
            this.btnAdd_LocalImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd_LocalImage.Name = "btnAdd_LocalImage";
            this.btnAdd_LocalImage.Size = new System.Drawing.Size(30, 22);
            this.btnAdd_LocalImage.TabIndex = 23;
            this.btnAdd_LocalImage.Text = "+";
            this.btnAdd_LocalImage.UseVisualStyleBackColor = true;
            this.btnAdd_LocalImage.Click += new System.EventHandler(this.btnAdd_LocalImage_Click);
            // 
            // btnCancelar__Nuevo
            // 
            this.btnCancelar__Nuevo.BackColor = System.Drawing.Color.White;
            this.btnCancelar__Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar__Nuevo.Location = new System.Drawing.Point(267, 406);
            this.btnCancelar__Nuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar__Nuevo.Name = "btnCancelar__Nuevo";
            this.btnCancelar__Nuevo.Size = new System.Drawing.Size(142, 39);
            this.btnCancelar__Nuevo.TabIndex = 26;
            this.btnCancelar__Nuevo.Text = "Cancelar";
            this.btnCancelar__Nuevo.UseVisualStyleBackColor = false;
            this.btnCancelar__Nuevo.Click += new System.EventHandler(this.btnCancelar__Nuevo_Click);
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(93)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(514, 489);
            this.Controls.Add(this.btnCancelar__Nuevo);
            this.Controls.Add(this.btnAgregar__Nuevo);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoProducto";
            this.Load += new System.EventHandler(this.frmNuevoProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodArticulo__Nuevo;
        private System.Windows.Forms.TextBox txtCodigo__Nuevo;
        private System.Windows.Forms.TextBox txtNombre__Nuevo;
        private System.Windows.Forms.Label lblNombre__Nuevo;
        private System.Windows.Forms.TextBox txtDescripcion__Nuevo;
        private System.Windows.Forms.Label lblDescripcion__Nuevo;
        private System.Windows.Forms.Button btnAgregar__Nuevo;
        private System.Windows.Forms.Label lblMarca_Nuevo;
        private System.Windows.Forms.ComboBox cbMarca_Nuevo;
        private System.Windows.Forms.Label lblCategoria_nuevo;
        private System.Windows.Forms.ComboBox cbCategoria_Nuevo;
        private System.Windows.Forms.TextBox txtPrecio_Nuevo;
        private System.Windows.Forms.Label lblPrecio_Nuevo;
        private System.Windows.Forms.TextBox txtUrlImagen_Nuevo;
        private System.Windows.Forms.Label lblUrlImage_Nuevo;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar__Nuevo;
        private System.Windows.Forms.Button btnAdd_LocalImage;
    }
}