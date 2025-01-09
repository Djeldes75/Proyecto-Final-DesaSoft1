namespace SistemaGestionInventario
{
    partial class FrmCategorias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategorias));
            this.label_CategoriaID = new System.Windows.Forms.Label();
            this.label_NombreCategoria = new System.Windows.Forms.Label();
            this.label_DescripcionCategoria = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestorInventarioDataSet = new SistemaGestionInventario.GestorInventarioDataSet();
            this.categoriasTableAdapter = new SistemaGestionInventario.GestorInventarioDataSetTableAdapters.CategoriasTableAdapter();
            this.textBox_CategoriaID = new System.Windows.Forms.TextBox();
            this.textBox_NombreCategoria = new System.Windows.Forms.TextBox();
            this.textBox_DescripcionCategoria = new System.Windows.Forms.TextBox();
            this.pictureBox_LogoGestor_FrmCategorias = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorInventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoGestor_FrmCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CategoriaID
            // 
            this.label_CategoriaID.AutoSize = true;
            this.label_CategoriaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CategoriaID.Location = new System.Drawing.Point(40, 36);
            this.label_CategoriaID.Name = "label_CategoriaID";
            this.label_CategoriaID.Size = new System.Drawing.Size(95, 20);
            this.label_CategoriaID.TabIndex = 0;
            this.label_CategoriaID.Text = "CategoriaID";
            // 
            // label_NombreCategoria
            // 
            this.label_NombreCategoria.AutoSize = true;
            this.label_NombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreCategoria.Location = new System.Drawing.Point(37, 123);
            this.label_NombreCategoria.Name = "label_NombreCategoria";
            this.label_NombreCategoria.Size = new System.Drawing.Size(176, 20);
            this.label_NombreCategoria.TabIndex = 1;
            this.label_NombreCategoria.Text = "Nombre de la Categoria";
            this.label_NombreCategoria.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_DescripcionCategoria
            // 
            this.label_DescripcionCategoria.AutoSize = true;
            this.label_DescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescripcionCategoria.Location = new System.Drawing.Point(40, 208);
            this.label_DescripcionCategoria.Name = "label_DescripcionCategoria";
            this.label_DescripcionCategoria.Size = new System.Drawing.Size(92, 20);
            this.label_DescripcionCategoria.TabIndex = 2;
            this.label_DescripcionCategoria.Text = "Descripcion";
            this.label_DescripcionCategoria.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.Green;
            this.btnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(435, 294);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(114, 48);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEditarCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarCategoria.Location = new System.Drawing.Point(435, 368);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(114, 48);
            this.btnEditarCategoria.TabIndex = 4;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(435, 437);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(114, 48);
            this.btnEliminarCategoria.TabIndex = 5;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 204);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.gestorInventarioDataSet;
            // 
            // gestorInventarioDataSet
            // 
            this.gestorInventarioDataSet.DataSetName = "GestorInventarioDataSet";
            this.gestorInventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_CategoriaID
            // 
            this.textBox_CategoriaID.Location = new System.Drawing.Point(41, 76);
            this.textBox_CategoriaID.Name = "textBox_CategoriaID";
            this.textBox_CategoriaID.Size = new System.Drawing.Size(172, 20);
            this.textBox_CategoriaID.TabIndex = 7;
            // 
            // textBox_NombreCategoria
            // 
            this.textBox_NombreCategoria.Location = new System.Drawing.Point(41, 165);
            this.textBox_NombreCategoria.Name = "textBox_NombreCategoria";
            this.textBox_NombreCategoria.Size = new System.Drawing.Size(172, 20);
            this.textBox_NombreCategoria.TabIndex = 8;
            // 
            // textBox_DescripcionCategoria
            // 
            this.textBox_DescripcionCategoria.Location = new System.Drawing.Point(41, 244);
            this.textBox_DescripcionCategoria.Name = "textBox_DescripcionCategoria";
            this.textBox_DescripcionCategoria.Size = new System.Drawing.Size(172, 20);
            this.textBox_DescripcionCategoria.TabIndex = 9;
            // 
            // pictureBox_LogoGestor_FrmCategorias
            // 
            this.pictureBox_LogoGestor_FrmCategorias.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_LogoGestor_FrmCategorias.Image")));
            this.pictureBox_LogoGestor_FrmCategorias.Location = new System.Drawing.Point(355, 46);
            this.pictureBox_LogoGestor_FrmCategorias.Name = "pictureBox_LogoGestor_FrmCategorias";
            this.pictureBox_LogoGestor_FrmCategorias.Size = new System.Drawing.Size(178, 168);
            this.pictureBox_LogoGestor_FrmCategorias.TabIndex = 10;
            this.pictureBox_LogoGestor_FrmCategorias.TabStop = false;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 519);
            this.Controls.Add(this.pictureBox_LogoGestor_FrmCategorias);
            this.Controls.Add(this.textBox_DescripcionCategoria);
            this.Controls.Add(this.textBox_NombreCategoria);
            this.Controls.Add(this.textBox_CategoriaID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.label_DescripcionCategoria);
            this.Controls.Add(this.label_NombreCategoria);
            this.Controls.Add(this.label_CategoriaID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategorias";
            this.Text = "FrmCategorias";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestorInventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LogoGestor_FrmCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CategoriaID;
        private System.Windows.Forms.Label label_NombreCategoria;
        private System.Windows.Forms.Label label_DescripcionCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GestorInventarioDataSet gestorInventarioDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private GestorInventarioDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_CategoriaID;
        private System.Windows.Forms.TextBox textBox_NombreCategoria;
        private System.Windows.Forms.TextBox textBox_DescripcionCategoria;
        private System.Windows.Forms.PictureBox pictureBox_LogoGestor_FrmCategorias;
    }
}