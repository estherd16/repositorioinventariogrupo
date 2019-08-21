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
            this.buttonGuardar = new System.Windows.Forms.Button();
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
            this.tabFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFactura.Location = new System.Drawing.Point(-1, 2);
            this.tabFactura.Name = "tabFactura";
            this.tabFactura.SelectedIndex = 0;
            this.tabFactura.Size = new System.Drawing.Size(487, 459);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(204, 291);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 32);
            this.buttonGuardar.TabIndex = 14;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dateTimePickerFechaFac
            // 
            this.dateTimePickerFechaFac.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFac.Location = new System.Drawing.Point(152, 143);
            this.dateTimePickerFechaFac.Name = "dateTimePickerFechaFac";
            this.dateTimePickerFechaFac.Size = new System.Drawing.Size(301, 27);
            this.dateTimePickerFechaFac.TabIndex = 9;
            // 
            // comboBoxCodCliente
            // 
            this.comboBoxCodCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCodCliente.FormattingEnabled = true;
            this.comboBoxCodCliente.Location = new System.Drawing.Point(152, 193);
            this.comboBoxCodCliente.Name = "comboBoxCodCliente";
            this.comboBoxCodCliente.Size = new System.Drawing.Size(301, 27);
            this.comboBoxCodCliente.TabIndex = 8;
            // 
            // textBoxCodFac
            // 
            this.textBoxCodFac.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodFac.Location = new System.Drawing.Point(152, 99);
            this.textBoxCodFac.Name = "textBoxCodFac";
            this.textBoxCodFac.Size = new System.Drawing.Size(301, 27);
            this.textBoxCodFac.TabIndex = 7;
            // 
            // comboBoxCodEmpleado
            // 
            this.comboBoxCodEmpleado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCodEmpleado.FormattingEnabled = true;
            this.comboBoxCodEmpleado.Location = new System.Drawing.Point(152, 237);
            this.comboBoxCodEmpleado.Name = "comboBoxCodEmpleado";
            this.comboBoxCodEmpleado.Size = new System.Drawing.Size(301, 27);
            this.comboBoxCodEmpleado.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registrar Factura";
            // 
            // labelcodemple
            // 
            this.labelcodemple.AutoSize = true;
            this.labelcodemple.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodemple.Location = new System.Drawing.Point(9, 240);
            this.labelcodemple.Name = "labelcodemple";
            this.labelcodemple.Size = new System.Drawing.Size(79, 19);
            this.labelcodemple.TabIndex = 4;
            this.labelcodemple.Text = "Empleado";
            // 
            // labelcodcliente
            // 
            this.labelcodcliente.AutoSize = true;
            this.labelcodcliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodcliente.Location = new System.Drawing.Point(9, 196);
            this.labelcodcliente.Name = "labelcodcliente";
            this.labelcodcliente.Size = new System.Drawing.Size(57, 19);
            this.labelcodcliente.TabIndex = 3;
            this.labelcodcliente.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // labelcodigofac
            // 
            this.labelcodigofac.AutoSize = true;
            this.labelcodigofac.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcodigofac.Location = new System.Drawing.Point(9, 106);
            this.labelcodigofac.Name = "labelcodigofac";
            this.labelcodigofac.Size = new System.Drawing.Size(59, 19);
            this.labelcodigofac.TabIndex = 0;
            this.labelcodigofac.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxBuscarFactura);
            this.tabPage2.Controls.Add(this.dataGridViewFactura);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarFactura
            // 
            this.textBoxBuscarFactura.Location = new System.Drawing.Point(76, 57);
            this.textBoxBuscarFactura.Name = "textBoxBuscarFactura";
            this.textBoxBuscarFactura.Size = new System.Drawing.Size(316, 26);
            this.textBoxBuscarFactura.TabIndex = 15;
            this.textBoxBuscarFactura.TextChanged += new System.EventHandler(this.textBoxBuscarFactura_TextChanged);
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(0, 109);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.Size = new System.Drawing.Size(476, 314);
            this.dataGridViewFactura.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Buscar";
            // 
            // FFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tabFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.TextBox textBoxBuscarFactura;
        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGuardar;
    }
}