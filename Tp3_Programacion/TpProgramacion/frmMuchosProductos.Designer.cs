
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
            this.cboMarca__Todos = new System.Windows.Forms.ComboBox();
            this.lblMarca__muchos = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ColumNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregar_Todos = new System.Windows.Forms.Button();
            this.btnEditar__Todos = new System.Windows.Forms.Button();
            this.btnBorrar__Todos = new System.Windows.Forms.Button();
            this.lblCategorias__Todos = new System.Windows.Forms.Label();
            this.cboCategoria__Todos = new System.Windows.Forms.ComboBox();
            this.btnVerDetalle__Todos = new System.Windows.Forms.Button();
            this.lblOrden__todos = new System.Windows.Forms.Label();
            this.cboOrdenPrice__Todos = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dvgTodosLosProductos = new System.Windows.Forms.DataGridView();
            this.pbxTodos = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosLosProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMarca__Todos
            // 
            this.cboMarca__Todos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca__Todos.FormattingEnabled = true;
            this.cboMarca__Todos.Location = new System.Drawing.Point(10, 52);
            this.cboMarca__Todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMarca__Todos.Name = "cboMarca__Todos";
            this.cboMarca__Todos.Size = new System.Drawing.Size(298, 28);
            this.cboMarca__Todos.TabIndex = 2;
            this.cboMarca__Todos.DropDownClosed += new System.EventHandler(this.cboMarca__Todos_DropDownClosed);
            // 
            // lblMarca__muchos
            // 
            this.lblMarca__muchos.AutoSize = true;
            this.lblMarca__muchos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca__muchos.Location = new System.Drawing.Point(6, 23);
            this.lblMarca__muchos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca__muchos.Name = "lblMarca__muchos";
            this.lblMarca__muchos.Size = new System.Drawing.Size(153, 25);
            this.lblMarca__muchos.TabIndex = 3;
            this.lblMarca__muchos.Text = "Filtrar por Marca";
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
            // btnAgregar_Todos
            // 
            this.btnAgregar_Todos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar_Todos.Location = new System.Drawing.Point(22, 600);
            this.btnAgregar_Todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar_Todos.Name = "btnAgregar_Todos";
            this.btnAgregar_Todos.Size = new System.Drawing.Size(204, 54);
            this.btnAgregar_Todos.TabIndex = 6;
            this.btnAgregar_Todos.Text = "Agregar";
            this.btnAgregar_Todos.UseVisualStyleBackColor = false;
            this.btnAgregar_Todos.Click += new System.EventHandler(this.btnAgregar_Todos_Click);
            // 
            // btnEditar__Todos
            // 
            this.btnEditar__Todos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditar__Todos.Location = new System.Drawing.Point(291, 600);
            this.btnEditar__Todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar__Todos.Name = "btnEditar__Todos";
            this.btnEditar__Todos.Size = new System.Drawing.Size(204, 54);
            this.btnEditar__Todos.TabIndex = 7;
            this.btnEditar__Todos.Text = "Editar";
            this.btnEditar__Todos.UseVisualStyleBackColor = false;
            this.btnEditar__Todos.Click += new System.EventHandler(this.btnEditar__Todos_Click);
            // 
            // btnBorrar__Todos
            // 
            this.btnBorrar__Todos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBorrar__Todos.Location = new System.Drawing.Point(552, 600);
            this.btnBorrar__Todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar__Todos.Name = "btnBorrar__Todos";
            this.btnBorrar__Todos.Size = new System.Drawing.Size(204, 54);
            this.btnBorrar__Todos.TabIndex = 8;
            this.btnBorrar__Todos.Text = "Borrar";
            this.btnBorrar__Todos.UseVisualStyleBackColor = false;
            this.btnBorrar__Todos.Click += new System.EventHandler(this.btnBorrar__Todos_Click);
            // 
            // lblCategorias__Todos
            // 
            this.lblCategorias__Todos.AutoSize = true;
            this.lblCategorias__Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias__Todos.Location = new System.Drawing.Point(400, 23);
            this.lblCategorias__Todos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias__Todos.Name = "lblCategorias__Todos";
            this.lblCategorias__Todos.Size = new System.Drawing.Size(183, 25);
            this.lblCategorias__Todos.TabIndex = 10;
            this.lblCategorias__Todos.Text = "Filtrar por Categoria";
            // 
            // cboCategoria__Todos
            // 
            this.cboCategoria__Todos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria__Todos.FormattingEnabled = true;
            this.cboCategoria__Todos.Location = new System.Drawing.Point(405, 52);
            this.cboCategoria__Todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCategoria__Todos.Name = "cboCategoria__Todos";
            this.cboCategoria__Todos.Size = new System.Drawing.Size(298, 28);
            this.cboCategoria__Todos.TabIndex = 9;
            this.cboCategoria__Todos.DropDownClosed += new System.EventHandler(this.cboCategoria__Todos_DropDownClosed);
            // 
            // btnVerDetalle__Todos
            // 
            this.btnVerDetalle__Todos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnVerDetalle__Todos.Location = new System.Drawing.Point(814, 600);
            this.btnVerDetalle__Todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerDetalle__Todos.Name = "btnVerDetalle__Todos";
            this.btnVerDetalle__Todos.Size = new System.Drawing.Size(204, 54);
            this.btnVerDetalle__Todos.TabIndex = 11;
            this.btnVerDetalle__Todos.Text = "Ver Detalle";
            this.btnVerDetalle__Todos.UseVisualStyleBackColor = false;
            this.btnVerDetalle__Todos.Click += new System.EventHandler(this.btnVerDetalle__Todos_Click);
            // 
            // lblOrden__todos
            // 
            this.lblOrden__todos.AutoSize = true;
            this.lblOrden__todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden__todos.Location = new System.Drawing.Point(798, 23);
            this.lblOrden__todos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrden__todos.Name = "lblOrden__todos";
            this.lblOrden__todos.Size = new System.Drawing.Size(175, 25);
            this.lblOrden__todos.TabIndex = 13;
            this.lblOrden__todos.Text = "Ordenar por precio";
            // 
            // cboOrdenPrice__Todos
            // 
            this.cboOrdenPrice__Todos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenPrice__Todos.FormattingEnabled = true;
            this.cboOrdenPrice__Todos.Location = new System.Drawing.Point(798, 52);
            this.cboOrdenPrice__Todos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboOrdenPrice__Todos.Name = "cboOrdenPrice__Todos";
            this.cboOrdenPrice__Todos.Size = new System.Drawing.Size(298, 28);
            this.cboOrdenPrice__Todos.TabIndex = 12;
            this.cboOrdenPrice__Todos.DropDownClosed += new System.EventHandler(this.cboOrdenPrice__Todos_DropDownClosed);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblOrden__todos);
            this.panel2.Controls.Add(this.cboOrdenPrice__Todos);
            this.panel2.Controls.Add(this.lblCategorias__Todos);
            this.panel2.Controls.Add(this.cboCategoria__Todos);
            this.panel2.Controls.Add(this.lblMarca__muchos);
            this.panel2.Controls.Add(this.cboMarca__Todos);
            this.panel2.Location = new System.Drawing.Point(22, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 104);
            this.panel2.TabIndex = 15;
            // 
            // dvgTodosLosProductos
            // 
            this.dvgTodosLosProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgTodosLosProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgTodosLosProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgTodosLosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTodosLosProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvgTodosLosProductos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvgTodosLosProductos.Location = new System.Drawing.Point(33, 18);
            this.dvgTodosLosProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgTodosLosProductos.MultiSelect = false;
            this.dvgTodosLosProductos.Name = "dvgTodosLosProductos";
            this.dvgTodosLosProductos.RowHeadersWidth = 62;
            this.dvgTodosLosProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTodosLosProductos.Size = new System.Drawing.Size(1038, 360);
            this.dvgTodosLosProductos.TabIndex = 4;
            this.dvgTodosLosProductos.SelectionChanged += new System.EventHandler(this.dvgTodosLosProductos_SelectionChanged);
            // 
            // pbxTodos
            // 
            this.pbxTodos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbxTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxTodos.Location = new System.Drawing.Point(1126, 18);
            this.pbxTodos.Name = "pbxTodos";
            this.pbxTodos.Size = new System.Drawing.Size(390, 358);
            this.pbxTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTodos.TabIndex = 5;
            this.pbxTodos.TabStop = false;
            // 
            // frmMuchosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1694, 675);
            this.Controls.Add(this.pbxTodos);
            this.Controls.Add(this.dvgTodosLosProductos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVerDetalle__Todos);
            this.Controls.Add(this.btnBorrar__Todos);
            this.Controls.Add(this.btnEditar__Todos);
            this.Controls.Add(this.btnAgregar_Todos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1716, 731);
            this.MinimumSize = new System.Drawing.Size(1716, 731);
            this.Name = "frmMuchosProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos los productos";
            this.Load += new System.EventHandler(this.frmMuchosProductos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosLosProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTodos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMarca__Todos;
        private System.Windows.Forms.Label lblMarca__muchos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader ColumNombre;
        private System.Windows.Forms.ColumnHeader ColumDescripcion;
        private System.Windows.Forms.ColumnHeader ColumMarca;
        private System.Windows.Forms.ColumnHeader ColumPrecio;
        private System.Windows.Forms.Button btnAgregar_Todos;
        private System.Windows.Forms.Button btnEditar__Todos;
        private System.Windows.Forms.Button btnBorrar__Todos;
        private System.Windows.Forms.Label lblCategorias__Todos;
        private System.Windows.Forms.ComboBox cboCategoria__Todos;
        private System.Windows.Forms.Button btnVerDetalle__Todos;
        private System.Windows.Forms.Label lblOrden__todos;
        private System.Windows.Forms.ComboBox cboOrdenPrice__Todos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dvgTodosLosProductos;
        private System.Windows.Forms.PictureBox pbxTodos;
    }
}