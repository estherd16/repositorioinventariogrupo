namespace capaPresentacionWF
{
    partial class FFactura
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
            this.tabFactura = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerFechaFac = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCodCliente = new System.Windows.Forms.ComboBox();
            this.textBoxCodFac = new System.Windows.Forms.TextBox();
            this.comboBoxCodEmpleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelcodemple = new System.Windows.Forms.Label();
            this.labelcodcliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcodigofac = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxBuscarFactura = new System.Windows.Forms.TextBox();
            this.dataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.tabFactura.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFactura
            // 
            this.tabFactura.Controls.Add(this.tabPage1);
            this.tabFactura.Controls.Add(this.tabPage2);
            this.tabFactura.Location = new System.Drawing.Point(-1, 2);
            this.tabFactura.Name = "tabFactura";
            this.tabFactura.SelectedIndex = 0;
            this.tabFactura.Size = new System.Drawing.Size(422, 298);
            this.tabFactura.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.dateTimePickerFechaFac);
            this.tabPage1.Controls.Add(this.comboBoxCodCliente);
            this.tabPage1.Controls.Add(this.textBoxCodFac);
            this.tabPage1.Controls.Add(this.comboBoxCodEmpleado);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.labelcodemple);
            this.tabPage1.Controls.Add(this.labelcodcliente);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelcodigofac);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaFac
            // 
            this.dateTimePickerFechaFac.Location = new System.Drawing.Point(139, 132);
            this.dateTimePickerFechaFac.Name = "dateTimePickerFechaFac";
            this.dateTimePickerFechaFac.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaFac.TabIndex = 9;
            // 
            // comboBoxCodCliente
            // 
            this.comboBoxCodCliente.FormattingEnabled = true;
            this.comboBoxCodCliente.Location = new System.Drawing.Point(139, 164);
            this.comboBoxCodCliente.Name = "comboBoxCodCliente";
            this.comboBoxCodCliente.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCodCliente.TabIndex = 8;
            // 
            // textBoxCodFac
            // 
            this.textBoxCodFac.Location = new System.Drawing.Point(139, 99);
            this.textBoxCodFac.Name = "textBoxCodFac";
            this.textBoxCodFac.Size = new System.Drawing.Size(200, 20);
            this.textBoxCodFac.TabIndex = 7;
            // 
            // comboBoxCodEmpleado
            // 
            this.comboBoxCodEmpleado.FormattingEnabled = true;
            this.comboBoxCodEmpleado.Location = new System.Drawing.Point(139, 199);
            this.comboBoxCodEmpleado.Name = "comboBoxCodEmpleado";
            this.comboBoxCodEmpleado.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCodEmpleado.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registrar Factura";
            // 
            // labelcodemple
            // 
            this.labelcodemple.AutoSize = true;
            this.labelcodemple.Location = new System.Drawing.Point(46, 201);
            this.labelcodemple.Name = "labelcodemple";
            this.labelcodemple.Size = new System.Drawing.Size(90, 13);
            this.labelcodemple.TabIndex = 4;
            this.labelcodemple.Text = "Codigo Empleado";
            // 
            // labelcodcliente
            // 
            this.labelcodcliente.AutoSize = true;
            this.labelcodcliente.Location = new System.Drawing.Point(46, 167);
            this.labelcodcliente.Name = "labelcodcliente";
            this.labelcodcliente.Size = new System.Drawing.Size(75, 13);
            this.labelcodcliente.TabIndex = 3;
            this.labelcodcliente.Text = "Codigo Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // labelcodigofac
            // 
            this.labelcodigofac.AutoSize = true;
            this.labelcodigofac.Location = new System.Drawing.Point(46, 102);
            this.labelcodigofac.Name = "labelcodigofac";
            this.labelcodigofac.Size = new System.Drawing.Size(40, 13);
            this.labelcodigofac.TabIndex = 0;
            this.labelcodigofac.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxBuscarFactura);
            this.tabPage2.Controls.Add(this.dataGridViewFactura);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(414, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarFactura
            // 
            this.textBoxBuscarFactura.Location = new System.Drawing.Point(76, 57);
            this.textBoxBuscarFactura.Name = "textBoxBuscarFactura";
            this.textBoxBuscarFactura.Size = new System.Drawing.Size(316, 20);
            this.textBoxBuscarFactura.TabIndex = 15;
            this.textBoxBuscarFactura.TextChanged += new System.EventHandler(this.textBoxBuscarFactura_TextChanged);
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(0, 97);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.Size = new System.Drawing.Size(413, 175);
            this.dataGridViewFactura.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buscar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, -13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Buscar";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(187, 242);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 301);
            this.Controls.Add(this.tabFactura);
            this.Name = "FFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FFactura_Load);
            this.tabFactura.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFactura;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFac;
        private System.Windows.Forms.ComboBox comboBoxCodCliente;
        private System.Windows.Forms.TextBox textBoxCodFac;
        private System.Windows.Forms.ComboBox comboBoxCodEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelcodemple;
        private System.Windows.Forms.Label labelcodcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelcodigofac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBuscarFactura;
        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGuardar;
    }
}