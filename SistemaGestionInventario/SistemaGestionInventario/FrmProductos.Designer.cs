namespace SistemaGestionInventario
{
    partial class FrmProductos
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
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.comboBox_CategoriaProducto = new System.Windows.Forms.ComboBox();
            this.label_NombreProducto = new System.Windows.Forms.Label();
            this.label_CodigoProducto = new System.Windows.Forms.Label();
            this.label_CategoriaProducto = new System.Windows.Forms.Label();
            this.label_PrecioProducto = new System.Windows.Forms.Label();
            this.label_ExistenciaProducto = new System.Windows.Forms.Label();
            this.label_ProveedorProducto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_NombreProducto = new System.Windows.Forms.TextBox();
            this.textBox_CodigoProducto = new System.Windows.Forms.TextBox();
            this.textBox_PrecioProducto = new System.Windows.Forms.TextBox();
            this.textBox_ExistenciaProducto = new System.Windows.Forms.TextBox();
            this.textBox_ProveedorProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Green;
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarProducto.Location = new System.Drawing.Point(363, 257);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(95, 33);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditarProducto.Location = new System.Drawing.Point(363, 323);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(95, 34);
            this.btnEditarProducto.TabIndex = 1;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Red;
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProducto.Location = new System.Drawing.Point(363, 392);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(95, 35);
            this.btnEliminarProducto.TabIndex = 2;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // comboBox_CategoriaProducto
            // 
            this.comboBox_CategoriaProducto.FormattingEnabled = true;
            this.comboBox_CategoriaProducto.Location = new System.Drawing.Point(38, 216);
            this.comboBox_CategoriaProducto.Name = "comboBox_CategoriaProducto";
            this.comboBox_CategoriaProducto.Size = new System.Drawing.Size(203, 21);
            this.comboBox_CategoriaProducto.TabIndex = 3;
            this.comboBox_CategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_NombreProducto
            // 
            this.label_NombreProducto.AutoSize = true;
            this.label_NombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreProducto.Location = new System.Drawing.Point(35, 40);
            this.label_NombreProducto.Name = "label_NombreProducto";
            this.label_NombreProducto.Size = new System.Drawing.Size(65, 20);
            this.label_NombreProducto.TabIndex = 4;
            this.label_NombreProducto.Text = "Nombre";
            this.label_NombreProducto.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_CodigoProducto
            // 
            this.label_CodigoProducto.AutoSize = true;
            this.label_CodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CodigoProducto.Location = new System.Drawing.Point(35, 114);
            this.label_CodigoProducto.Name = "label_CodigoProducto";
            this.label_CodigoProducto.Size = new System.Drawing.Size(149, 20);
            this.label_CodigoProducto.TabIndex = 5;
            this.label_CodigoProducto.Text = "Código de Producto";
            // 
            // label_CategoriaProducto
            // 
            this.label_CategoriaProducto.AutoSize = true;
            this.label_CategoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CategoriaProducto.Location = new System.Drawing.Point(35, 189);
            this.label_CategoriaProducto.Name = "label_CategoriaProducto";
            this.label_CategoriaProducto.Size = new System.Drawing.Size(78, 20);
            this.label_CategoriaProducto.TabIndex = 6;
            this.label_CategoriaProducto.Text = "Categoría";
            // 
            // label_PrecioProducto
            // 
            this.label_PrecioProducto.AutoSize = true;
            this.label_PrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrecioProducto.Location = new System.Drawing.Point(35, 262);
            this.label_PrecioProducto.Name = "label_PrecioProducto";
            this.label_PrecioProducto.Size = new System.Drawing.Size(53, 20);
            this.label_PrecioProducto.TabIndex = 7;
            this.label_PrecioProducto.Text = "Precio";
            // 
            // label_ExistenciaProducto
            // 
            this.label_ExistenciaProducto.AutoSize = true;
            this.label_ExistenciaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ExistenciaProducto.Location = new System.Drawing.Point(35, 337);
            this.label_ExistenciaProducto.Name = "label_ExistenciaProducto";
            this.label_ExistenciaProducto.Size = new System.Drawing.Size(81, 20);
            this.label_ExistenciaProducto.TabIndex = 8;
            this.label_ExistenciaProducto.Text = "Existencia";
            // 
            // label_ProveedorProducto
            // 
            this.label_ProveedorProducto.AutoSize = true;
            this.label_ProveedorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ProveedorProducto.Location = new System.Drawing.Point(35, 416);
            this.label_ProveedorProducto.Name = "label_ProveedorProducto";
            this.label_ProveedorProducto.Size = new System.Drawing.Size(81, 20);
            this.label_ProveedorProducto.TabIndex = 9;
            this.label_ProveedorProducto.Text = "Proveedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(320, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 152);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_NombreProducto
            // 
            this.textBox_NombreProducto.Location = new System.Drawing.Point(38, 75);
            this.textBox_NombreProducto.Name = "textBox_NombreProducto";
            this.textBox_NombreProducto.Size = new System.Drawing.Size(203, 20);
            this.textBox_NombreProducto.TabIndex = 11;
            // 
            // textBox_CodigoProducto
            // 
            this.textBox_CodigoProducto.Location = new System.Drawing.Point(38, 146);
            this.textBox_CodigoProducto.Name = "textBox_CodigoProducto";
            this.textBox_CodigoProducto.Size = new System.Drawing.Size(203, 20);
            this.textBox_CodigoProducto.TabIndex = 12;
            // 
            // textBox_PrecioProducto
            // 
            this.textBox_PrecioProducto.Location = new System.Drawing.Point(38, 294);
            this.textBox_PrecioProducto.Name = "textBox_PrecioProducto";
            this.textBox_PrecioProducto.Size = new System.Drawing.Size(203, 20);
            this.textBox_PrecioProducto.TabIndex = 13;
            // 
            // textBox_ExistenciaProducto
            // 
            this.textBox_ExistenciaProducto.Location = new System.Drawing.Point(38, 367);
            this.textBox_ExistenciaProducto.Name = "textBox_ExistenciaProducto";
            this.textBox_ExistenciaProducto.Size = new System.Drawing.Size(203, 20);
            this.textBox_ExistenciaProducto.TabIndex = 14;
            // 
            // textBox_ProveedorProducto
            // 
            this.textBox_ProveedorProducto.Location = new System.Drawing.Point(38, 450);
            this.textBox_ProveedorProducto.Name = "textBox_ProveedorProducto";
            this.textBox_ProveedorProducto.Size = new System.Drawing.Size(203, 20);
            this.textBox_ProveedorProducto.TabIndex = 15;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(513, 506);
            this.Controls.Add(this.textBox_ProveedorProducto);
            this.Controls.Add(this.textBox_ExistenciaProducto);
            this.Controls.Add(this.textBox_PrecioProducto);
            this.Controls.Add(this.textBox_CodigoProducto);
            this.Controls.Add(this.textBox_NombreProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_ProveedorProducto);
            this.Controls.Add(this.label_ExistenciaProducto);
            this.Controls.Add(this.label_PrecioProducto);
            this.Controls.Add(this.label_CategoriaProducto);
            this.Controls.Add(this.label_CodigoProducto);
            this.Controls.Add(this.label_NombreProducto);
            this.Controls.Add(this.comboBox_CategoriaProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Name = "FrmProductos";
            this.Text = "Gestion De Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ComboBox comboBox_CategoriaProducto;
        private System.Windows.Forms.Label label_NombreProducto;
        private System.Windows.Forms.Label label_CodigoProducto;
        private System.Windows.Forms.Label label_CategoriaProducto;
        private System.Windows.Forms.Label label_PrecioProducto;
        private System.Windows.Forms.Label label_ExistenciaProducto;
        private System.Windows.Forms.Label label_ProveedorProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_NombreProducto;
        private System.Windows.Forms.TextBox textBox_CodigoProducto;
        private System.Windows.Forms.TextBox textBox_PrecioProducto;
        private System.Windows.Forms.TextBox textBox_ExistenciaProducto;
        private System.Windows.Forms.TextBox textBox_ProveedorProducto;
    }
}

