namespace capaPresentacionWF
{
    partial class FVentas
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
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxcodfact = new System.Windows.Forms.ComboBox();
            this.comboBoxcodprod = new System.Windows.Forms.ComboBox();
            this.buttonGuardarVen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxcodven = new System.Windows.Forms.TextBox();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxBuscarVenta = new System.Windows.Forms.TextBox();
            this.dataGridViewVentas = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tabVentas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tabPage1);
            this.tabVentas.Controls.Add(this.tabPage2);
            this.tabVentas.Location = new System.Drawing.Point(2, 1);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(415, 394);
            this.tabVentas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBoxcodfact);
            this.tabPage1.Controls.Add(this.comboBoxcodprod);
            this.tabPage1.Controls.Add(this.buttonGuardarVen);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxprecio);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxcantidad);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxcodven);
            this.tabPage1.Controls.Add(this.labelcodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxcodfact
            // 
            this.comboBoxcodfact.FormattingEnabled = true;
            this.comboBoxcodfact.Location = new System.Drawing.Point(116, 208);
            this.comboBoxcodfact.Name = "comboBoxcodfact";
            this.comboBoxcodfact.Size = new System.Drawing.Size(201, 21);
            this.comboBoxcodfact.TabIndex = 29;
            // 
            // comboBoxcodprod
            // 
            this.comboBoxcodprod.FormattingEnabled = true;
            this.comboBoxcodprod.Location = new System.Drawing.Point(116, 173);
            this.comboBoxcodprod.Name = "comboBoxcodprod";
            this.comboBoxcodprod.Size = new System.Drawing.Size(201, 21);
            this.comboBoxcodprod.TabIndex = 28;
            // 
            // buttonGuardarVen
            // 
            this.buttonGuardarVen.Location = new System.Drawing.Point(174, 246);
            this.buttonGuardarVen.Name = "buttonGuardarVen";
            this.buttonGuardarVen.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarVen.TabIndex = 27;
            this.buttonGuardarVen.Text = "Guardar";
            this.buttonGuardarVen.UseVisualStyleBackColor = true;
            this.buttonGuardarVen.Click += new System.EventHandler(this.buttonGuardarVen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Registrar Ventas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Código factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Código producto";
            // 
            // textBoxprecio
            // 
            this.textBoxprecio.Location = new System.Drawing.Point(116, 141);
            this.textBoxprecio.Name = "textBoxprecio";
            this.textBoxprecio.Size = new System.Drawing.Size(201, 20);
            this.textBoxprecio.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Precio";
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Location = new System.Drawing.Point(116, 106);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(201, 20);
            this.textBoxcantidad.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad";
            // 
            // textBoxcodven
            // 
            this.textBoxcodven.Location = new System.Drawing.Point(116, 77);
            this.textBoxcodven.Name = "textBoxcodven";
            this.textBoxcodven.Size = new System.Drawing.Size(201, 20);
            this.textBoxcodven.TabIndex = 15;
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Location = new System.Drawing.Point(55, 80);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(40, 13);
            this.labelcodigo.TabIndex = 14;
            this.labelcodigo.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxBuscarVenta);
            this.tabPage2.Controls.Add(this.dataGridViewVentas);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarVenta
            // 
            this.textBoxBuscarVenta.Location = new System.Drawing.Point(61, 52);
            this.textBoxBuscarVenta.Name = "textBoxBuscarVenta";
            this.textBoxBuscarVenta.Size = new System.Drawing.Size(292, 20);
            this.textBoxBuscarVenta.TabIndex = 19;
            this.textBoxBuscarVenta.TextChanged += new System.EventHandler(this.textBoxBuscarVenta_TextChanged);
            // 
            // dataGridViewVentas
            // 
            this.dataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentas.Location = new System.Drawing.Point(3, 127);
            this.dataGridViewVentas.Name = "dataGridViewVentas";
            this.dataGridViewVentas.Size = new System.Drawing.Size(401, 235);
            this.dataGridViewVentas.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Buscar";
            // 
            // FVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 397);
            this.Controls.Add(this.tabVentas);
            this.Name = "FVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FVentas_Load);
            this.tabVentas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxcodfact;
        private System.Windows.Forms.ComboBox comboBoxcodprod;
        private System.Windows.Forms.Button buttonGuardarVen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxcodven;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxBuscarVenta;
        private System.Windows.Forms.DataGridView dataGridViewVentas;
        private System.Windows.Forms.Label label9;
    }
}