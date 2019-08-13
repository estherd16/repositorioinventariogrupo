namespace capaPresentacionWF
{
    partial class Fcategoria
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabCategoria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxidCat = new System.Windows.Forms.TextBox();
            this.textBoxNomCat = new System.Windows.Forms.TextBox();
            this.textBoxDesCat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Buscar = new System.Windows.Forms.Label();
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.buttonEliminarCat = new System.Windows.Forms.Button();
            this.buttoneditar = new System.Windows.Forms.Button();
            this.textBoxBuscarCat = new System.Windows.Forms.TextBox();
            this.tabCategoria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabCategoria
            // 
            this.tabCategoria.Controls.Add(this.tabPage1);
            this.tabCategoria.Controls.Add(this.tabPage2);
            this.tabCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCategoria.Location = new System.Drawing.Point(1, 2);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.SelectedIndex = 0;
            this.tabCategoria.Size = new System.Drawing.Size(482, 457);
            this.tabCategoria.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxidCat);
            this.tabPage1.Controls.Add(this.textBoxNomCat);
            this.tabPage1.Controls.Add(this.textBoxDesCat);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelid);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(203, 322);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(89, 29);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxidCat
            // 
            this.textBoxidCat.Location = new System.Drawing.Point(128, 131);
            this.textBoxidCat.Name = "textBoxidCat";
            this.textBoxidCat.Size = new System.Drawing.Size(271, 22);
            this.textBoxidCat.TabIndex = 17;
            // 
            // textBoxNomCat
            // 
            this.textBoxNomCat.Location = new System.Drawing.Point(128, 171);
            this.textBoxNomCat.Name = "textBoxNomCat";
            this.textBoxNomCat.Size = new System.Drawing.Size(271, 22);
            this.textBoxNomCat.TabIndex = 16;
            // 
            // textBoxDesCat
            // 
            this.textBoxDesCat.Location = new System.Drawing.Point(128, 211);
            this.textBoxDesCat.Multiline = true;
            this.textBoxDesCat.Name = "textBoxDesCat";
            this.textBoxDesCat.Size = new System.Drawing.Size(271, 90);
            this.textBoxDesCat.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Registrar Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(32, 132);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(59, 19);
            this.labelid.TabIndex = 11;
            this.labelid.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Buscar);
            this.tabPage2.Controls.Add(this.dataGridViewCategoria);
            this.tabPage2.Controls.Add(this.buttonEliminarCat);
            this.tabPage2.Controls.Add(this.buttoneditar);
            this.tabPage2.Controls.Add(this.textBoxBuscarCat);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(3, 61);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(55, 19);
            this.Buscar.TabIndex = 5;
            this.Buscar.Text = "Buscar";
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(3, 111);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.Size = new System.Drawing.Size(465, 317);
            this.dataGridViewCategoria.TabIndex = 4;
            // 
            // buttonEliminarCat
            // 
            this.buttonEliminarCat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCat.Location = new System.Drawing.Point(392, 56);
            this.buttonEliminarCat.Name = "buttonEliminarCat";
            this.buttonEliminarCat.Size = new System.Drawing.Size(75, 29);
            this.buttonEliminarCat.TabIndex = 2;
            this.buttonEliminarCat.Text = "Eliminar";
            this.buttonEliminarCat.UseVisualStyleBackColor = true;
            this.buttonEliminarCat.Click += new System.EventHandler(this.buttonEliminarCat_Click);
            // 
            // buttoneditar
            // 
            this.buttoneditar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneditar.Location = new System.Drawing.Point(307, 56);
            this.buttoneditar.Name = "buttoneditar";
            this.buttoneditar.Size = new System.Drawing.Size(75, 29);
            this.buttoneditar.TabIndex = 1;
            this.buttoneditar.Text = "Editar";
            this.buttoneditar.UseVisualStyleBackColor = true;
            this.buttoneditar.Click += new System.EventHandler(this.buttoneditar_Click);
            // 
            // textBoxBuscarCat
            // 
            this.textBoxBuscarCat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarCat.Location = new System.Drawing.Point(68, 58);
            this.textBoxBuscarCat.Name = "textBoxBuscarCat";
            this.textBoxBuscarCat.Size = new System.Drawing.Size(226, 27);
            this.textBoxBuscarCat.TabIndex = 0;
            this.textBoxBuscarCat.TextChanged += new System.EventHandler(this.textBoxBuscarCat_TextChanged);
            // 
            // Fcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabCategoria);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fcategoria";
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.Fcategoria_Load);
            this.tabCategoria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCategoria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxidCat;
        private System.Windows.Forms.TextBox textBoxNomCat;
        private System.Windows.Forms.TextBox textBoxDesCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.Button buttonEliminarCat;
        private System.Windows.Forms.Button buttoneditar;
        private System.Windows.Forms.TextBox textBoxBuscarCat;
    }
}

