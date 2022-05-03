
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMarca__muchos = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ColumNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dvgTodosLosProductos = new System.Windows.Forms.DataGridView();
            this.pbxTodos = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosLosProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 377);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lblMarca__muchos
            // 
            this.lblMarca__muchos.AutoSize = true;
            this.lblMarca__muchos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca__muchos.Location = new System.Drawing.Point(12, 358);
            this.lblMarca__muchos.Name = "lblMarca__muchos";
            this.lblMarca__muchos.Size = new System.Drawing.Size(105, 16);
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
            // dvgTodosLosProductos
            // 
            this.dvgTodosLosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTodosLosProductos.Location = new System.Drawing.Point(15, 25);
            this.dvgTodosLosProductos.Name = "dvgTodosLosProductos";
            this.dvgTodosLosProductos.Size = new System.Drawing.Size(664, 234);
            this.dvgTodosLosProductos.TabIndex = 4;
            this.dvgTodosLosProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTodosLosProductos_CellContentClick);
            this.dvgTodosLosProductos.SelectionChanged += new System.EventHandler(this.dvgTodosLosProductos_SelectionChanged);
            // 
            // pbxTodos
            // 
            this.pbxTodos.Location = new System.Drawing.Point(685, 25);
            this.pbxTodos.Name = "pbxTodos";
            this.pbxTodos.Size = new System.Drawing.Size(250, 234);
            this.pbxTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTodos.TabIndex = 5;
            this.pbxTodos.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMuchosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 528);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxTodos);
            this.Controls.Add(this.dvgTodosLosProductos);
            this.Controls.Add(this.lblMarca__muchos);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMuchosProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos los productos";
            this.Load += new System.EventHandler(this.frmMuchosProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTodosLosProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMarca__muchos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader ColumNombre;
        private System.Windows.Forms.ColumnHeader ColumDescripcion;
        private System.Windows.Forms.ColumnHeader ColumMarca;
        private System.Windows.Forms.ColumnHeader ColumPrecio;
        private System.Windows.Forms.DataGridView dvgTodosLosProductos;
        private System.Windows.Forms.PictureBox pbxTodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}