namespace capaPresentacionWF
{
    partial class FProductos
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
            this.tabProductos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxexistencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxcodprov = new System.Windows.Forms.ComboBox();
            this.comboBoxcodcat = new System.Windows.Forms.ComboBox();
            this.labelcodprov = new System.Windows.Forms.Label();
            this.labelcodcate = new System.Windows.Forms.Label();
            this.textBoxPrecioprod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.textBoxNombreproducto = new System.Windows.Forms.TextBox();
            this.textBoxcodproducto = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxBuscarProducto = new System.Windows.Forms.TextBox();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.buttonEditarProducto = new System.Windows.Forms.Button();
            this.buttonEliminarProducto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabProductos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.tabPage1);
            this.tabProductos.Controls.Add(this.tabPage2);
            this.tabProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProductos.Location = new System.Drawing.Point(0, 1);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.SelectedIndex = 0;
            this.tabProductos.Size = new System.Drawing.Size(499, 498);
            this.tabProductos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxexistencia);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBoxcodprov);
            this.tabPage1.Controls.Add(this.comboBoxcodcat);
            this.tabPage1.Controls.Add(this.labelcodprov);
            this.tabPage1.Controls.Add(this.labelcodcate);
            this.tabPage1.Controls.Add(this.textBoxPrecioprod);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelcodigo);
            this.tabPage1.Controls.Add(this.textBoxNombreproducto);
            this.tabPage1.Controls.Add(this.textBoxcodproducto);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(229, 346);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(86, 30);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxexistencia
            // 
            this.textBoxexistencia.Location = new System.Drawing.Point(177, 212);
            this.textBoxexistencia.Name = "textBoxexistencia";
            this.textBoxexistencia.Size = new System.Drawing.Size(254, 26);
            this.textBoxexistencia.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Registrar Productos";
            // 
            // comboBoxcodprov
            // 
            this.comboBoxcodprov.FormattingEnabled = true;
            this.comboBoxcodprov.Location = new System.Drawing.Point(177, 288);
            this.comboBoxcodprov.Name = "comboBoxcodprov";
            this.comboBoxcodprov.Size = new System.Drawing.Size(254, 28);
            this.comboBoxcodprov.TabIndex = 11;
            // 
            // comboBoxcodcat
            // 
            this.comboBoxcodcat.FormattingEnabled = true;
            this.comboBoxcodcat.Location = new System.Drawing.Point(177, 248);
            this.comboBoxcodcat.Name = "comboBoxcodcat";
            this.comboBoxcodcat.Size = new System.Drawing.Size(254, 28);
            this.comboBoxcodcat.TabIndex = 10;
            // 
            // labelcodprov
            // 
            this.labelcodprov.AutoSize = true;
            this.labelcodprov.Location = new System.Drawing.Point(25, 291);
            this.labelcodprov.Name = "labelcodprov";
            this.labelcodprov.Size = new System.Drawing.Size(81, 20);
            this.labelcodprov.TabIndex = 9;
            this.labelcodprov.Text = "Proveedor";
            // 
            // labelcodcate
            // 
            this.labelcodcate.AutoSize = true;
            this.labelcodcate.Location = new System.Drawing.Point(25, 251);
            this.labelcodcate.Name = "labelcodcate";
            this.labelcodcate.Size = new System.Drawing.Size(78, 20);
            this.labelcodcate.TabIndex = 8;
            this.labelcodcate.Text = "Categoria";
            // 
            // textBoxPrecioprod
            // 
            this.textBoxPrecioprod.Location = new System.Drawing.Point(177, 178);
            this.textBoxPrecioprod.Name = "textBoxPrecioprod";
            this.textBoxPrecioprod.Size = new System.Drawing.Size(254, 26);
            this.textBoxPrecioprod.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Existencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Location = new System.Drawing.Point(25, 107);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(59, 20);
            this.labelcodigo.TabIndex = 2;
            this.labelcodigo.Text = "Código";
            // 
            // textBoxNombreproducto
            // 
            this.textBoxNombreproducto.Location = new System.Drawing.Point(177, 142);
            this.textBoxNombreproducto.Name = "textBoxNombreproducto";
            this.textBoxNombreproducto.Size = new System.Drawing.Size(254, 26);
            this.textBoxNombreproducto.TabIndex = 1;
            // 
            // textBoxcodproducto
            // 
            this.textBoxcodproducto.Location = new System.Drawing.Point(177, 104);
            this.textBoxcodproducto.Name = "textBoxcodproducto";
            this.textBoxcodproducto.Size = new System.Drawing.Size(254, 26);
            this.textBoxcodproducto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxBuscarProducto);
            this.tabPage2.Controls.Add(this.dataGridViewProducto);
            this.tabPage2.Controls.Add(this.buttonEditarProducto);
            this.tabPage2.Controls.Add(this.buttonEliminarProducto);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarProducto
            // 
            this.textBoxBuscarProducto.Location = new System.Drawing.Point(80, 57);
            this.textBoxBuscarProducto.Name = "textBoxBuscarProducto";
            this.textBoxBuscarProducto.Size = new System.Drawing.Size(233, 26);
            this.textBoxBuscarProducto.TabIndex = 14;
            this.textBoxBuscarProducto.TextChanged += new System.EventHandler(this.textBoxBuscarProducto_TextChanged);
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(0, 129);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(488, 333);
            this.dataGridViewProducto.TabIndex = 13;
            // 
            // buttonEditarProducto
            // 
            this.buttonEditarProducto.Location = new System.Drawing.Point(400, 57);
            this.buttonEditarProducto.Name = "buttonEditarProducto";
            this.buttonEditarProducto.Size = new System.Drawing.Size(75, 26);
            this.buttonEditarProducto.TabIndex = 12;
            this.buttonEditarProducto.Text = "Editar";
            this.buttonEditarProducto.UseVisualStyleBackColor = true;
            this.buttonEditarProducto.Click += new System.EventHandler(this.buttonEditarProducto_Click);
            // 
            // buttonEliminarProducto
            // 
            this.buttonEliminarProducto.Location = new System.Drawing.Point(319, 57);
            this.buttonEliminarProducto.Name = "buttonEliminarProducto";
            this.buttonEliminarProducto.Size = new System.Drawing.Size(75, 26);
            this.buttonEliminarProducto.TabIndex = 11;
            this.buttonEliminarProducto.Text = "Eliminar";
            this.buttonEliminarProducto.UseVisualStyleBackColor = true;
            this.buttonEliminarProducto.Click += new System.EventHandler(this.buttonEliminarProducto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Buscar";
            // 
            // FProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.tabProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FProductos_Load);
            this.tabProductos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProductos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxcodprov;
        private System.Windows.Forms.ComboBox comboBoxcodcat;
        private System.Windows.Forms.Label labelcodprov;
        private System.Windows.Forms.Label labelcodcate;
        private System.Windows.Forms.TextBox textBoxPrecioprod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.TextBox textBoxNombreproducto;
        private System.Windows.Forms.TextBox textBoxcodproducto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxBuscarProducto;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button buttonEditarProducto;
        private System.Windows.Forms.Button buttonEliminarProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxexistencia;
        private System.Windows.Forms.Button buttonGuardar;

    }
}