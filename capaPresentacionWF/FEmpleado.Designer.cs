namespace capaPresentacionWF
{
    partial class FEmpleado
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
            this.tabEmpleados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxCorreoEM = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoEM = new System.Windows.Forms.TextBox();
            this.textBoxDireccionEM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcodigo = new System.Windows.Forms.Label();
            this.textBoxApellidoEM = new System.Windows.Forms.TextBox();
            this.textBoxNombreEM = new System.Windows.Forms.TextBox();
            this.textBoxCedulaEM = new System.Windows.Forms.TextBox();
            this.textBoxCodigoEmpl = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxBuscarEM = new System.Windows.Forms.TextBox();
            this.dataGridViewEMPLE = new System.Windows.Forms.DataGridView();
            this.buttonEditarEM = new System.Windows.Forms.Button();
            this.buttonEliminarEM = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabEmpleados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMPLE)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Controls.Add(this.tabPage1);
            this.tabEmpleados.Controls.Add(this.tabPage2);
            this.tabEmpleados.Location = new System.Drawing.Point(2, 3);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.SelectedIndex = 0;
            this.tabEmpleados.Size = new System.Drawing.Size(412, 420);
            this.tabEmpleados.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCorreoEM);
            this.tabPage1.Controls.Add(this.textBoxTelefonoEM);
            this.tabPage1.Controls.Add(this.textBoxDireccionEM);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelcodigo);
            this.tabPage1.Controls.Add(this.textBoxApellidoEM);
            this.tabPage1.Controls.Add(this.textBoxNombreEM);
            this.tabPage1.Controls.Add(this.textBoxCedulaEM);
            this.tabPage1.Controls.Add(this.textBoxCodigoEmpl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxCorreoEM
            // 
            this.textBoxCorreoEM.Location = new System.Drawing.Point(121, 304);
            this.textBoxCorreoEM.Name = "textBoxCorreoEM";
            this.textBoxCorreoEM.Size = new System.Drawing.Size(209, 20);
            this.textBoxCorreoEM.TabIndex = 32;
            this.textBoxCorreoEM.TextChanged += new System.EventHandler(this.textBoxCorreoCli_TextChanged);
            // 
            // textBoxTelefonoEM
            // 
            this.textBoxTelefonoEM.Location = new System.Drawing.Point(121, 263);
            this.textBoxTelefonoEM.Name = "textBoxTelefonoEM";
            this.textBoxTelefonoEM.Size = new System.Drawing.Size(209, 20);
            this.textBoxTelefonoEM.TabIndex = 31;
            this.textBoxTelefonoEM.TextChanged += new System.EventHandler(this.textBoxTelefonoCli_TextChanged);
            // 
            // textBoxDireccionEM
            // 
            this.textBoxDireccionEM.Location = new System.Drawing.Point(122, 229);
            this.textBoxDireccionEM.Name = "textBoxDireccionEM";
            this.textBoxDireccionEM.Size = new System.Drawing.Size(209, 20);
            this.textBoxDireccionEM.TabIndex = 30;
            this.textBoxDireccionEM.TextChanged += new System.EventHandler(this.textBoxDireccionCli_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Correo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Telefono";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Direccion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(150, 344);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 26;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Registrar Empleados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Apellido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cedula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelcodigo
            // 
            this.labelcodigo.AutoSize = true;
            this.labelcodigo.Location = new System.Drawing.Point(57, 83);
            this.labelcodigo.Name = "labelcodigo";
            this.labelcodigo.Size = new System.Drawing.Size(43, 13);
            this.labelcodigo.TabIndex = 21;
            this.labelcodigo.Text = "Código ";
            this.labelcodigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxApellidoEM
            // 
            this.textBoxApellidoEM.Location = new System.Drawing.Point(122, 192);
            this.textBoxApellidoEM.Name = "textBoxApellidoEM";
            this.textBoxApellidoEM.Size = new System.Drawing.Size(209, 20);
            this.textBoxApellidoEM.TabIndex = 20;
            this.textBoxApellidoEM.TextChanged += new System.EventHandler(this.textBoxApellidoCli_TextChanged);
            // 
            // textBoxNombreEM
            // 
            this.textBoxNombreEM.Location = new System.Drawing.Point(121, 159);
            this.textBoxNombreEM.Name = "textBoxNombreEM";
            this.textBoxNombreEM.Size = new System.Drawing.Size(209, 20);
            this.textBoxNombreEM.TabIndex = 19;
            this.textBoxNombreEM.TextChanged += new System.EventHandler(this.textBoxNombreCli_TextChanged);
            // 
            // textBoxCedulaEM
            // 
            this.textBoxCedulaEM.Location = new System.Drawing.Point(121, 121);
            this.textBoxCedulaEM.Name = "textBoxCedulaEM";
            this.textBoxCedulaEM.Size = new System.Drawing.Size(209, 20);
            this.textBoxCedulaEM.TabIndex = 18;
            this.textBoxCedulaEM.TextChanged += new System.EventHandler(this.textBoxCedulaCli_TextChanged);
            // 
            // textBoxCodigoEmpl
            // 
            this.textBoxCodigoEmpl.Location = new System.Drawing.Point(121, 83);
            this.textBoxCodigoEmpl.Name = "textBoxCodigoEmpl";
            this.textBoxCodigoEmpl.Size = new System.Drawing.Size(209, 20);
            this.textBoxCodigoEmpl.TabIndex = 17;
            this.textBoxCodigoEmpl.TextChanged += new System.EventHandler(this.textBoxCodigoCli_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxBuscarEM);
            this.tabPage2.Controls.Add(this.dataGridViewEMPLE);
            this.tabPage2.Controls.Add(this.buttonEditarEM);
            this.tabPage2.Controls.Add(this.buttonEliminarEM);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarEM
            // 
            this.textBoxBuscarEM.Location = new System.Drawing.Point(52, 38);
            this.textBoxBuscarEM.Name = "textBoxBuscarEM";
            this.textBoxBuscarEM.Size = new System.Drawing.Size(159, 20);
            this.textBoxBuscarEM.TabIndex = 9;
            this.textBoxBuscarEM.TextChanged += new System.EventHandler(this.textBoxBuscarEM_TextChanged);
            // 
            // dataGridViewEMPLE
            // 
            this.dataGridViewEMPLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEMPLE.Location = new System.Drawing.Point(3, 79);
            this.dataGridViewEMPLE.Name = "dataGridViewEMPLE";
            this.dataGridViewEMPLE.Size = new System.Drawing.Size(398, 315);
            this.dataGridViewEMPLE.TabIndex = 8;
            // 
            // buttonEditarEM
            // 
            this.buttonEditarEM.Location = new System.Drawing.Point(217, 36);
            this.buttonEditarEM.Name = "buttonEditarEM";
            this.buttonEditarEM.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarEM.TabIndex = 7;
            this.buttonEditarEM.Text = "Editar";
            this.buttonEditarEM.UseVisualStyleBackColor = true;
            this.buttonEditarEM.Click += new System.EventHandler(this.buttonEditarEM_Click);
            // 
            // buttonEliminarEM
            // 
            this.buttonEliminarEM.Location = new System.Drawing.Point(298, 36);
            this.buttonEliminarEM.Name = "buttonEliminarEM";
            this.buttonEliminarEM.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarEM.TabIndex = 6;
            this.buttonEliminarEM.Text = "Eliminar";
            this.buttonEliminarEM.UseVisualStyleBackColor = true;
            this.buttonEliminarEM.Click += new System.EventHandler(this.buttonEliminarEM_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Buscar";
            // 
            // FEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 424);
            this.Controls.Add(this.tabEmpleados);
            this.Name = "FEmpleado";
            this.Text = "FEmpleado";
            this.Load += new System.EventHandler(this.FEmpleado_Load);
            this.tabEmpleados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEMPLE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmpleados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxCorreoEM;
        private System.Windows.Forms.TextBox textBoxTelefonoEM;
        private System.Windows.Forms.TextBox textBoxDireccionEM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelcodigo;
        private System.Windows.Forms.TextBox textBoxApellidoEM;
        private System.Windows.Forms.TextBox textBoxNombreEM;
        private System.Windows.Forms.TextBox textBoxCedulaEM;
        private System.Windows.Forms.TextBox textBoxCodigoEmpl;
        private System.Windows.Forms.TextBox textBoxBuscarEM;
        private System.Windows.Forms.DataGridView dataGridViewEMPLE;
        private System.Windows.Forms.Button buttonEditarEM;
        private System.Windows.Forms.Button buttonEliminarEM;
        private System.Windows.Forms.Label label9;
    }
}