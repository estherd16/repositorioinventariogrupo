using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaEntidades;

namespace capaPresentacionWF
{
    public partial class FFactura : Form
    {
        logicaNegocioFactura logicaNF = new logicaNegocioFactura();
        logicaNegocioClientes logicaNCL = new logicaNegocioClientes();
        logicaNegocioEmpleados logicaNEM = new logicaNegocioEmpleados();

        public FFactura()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text=="Guardar")
                {
                    Factura objetoFactura = new Factura();
                    objetoFactura.fechaFactura = Convert.ToDateTime(dateTimePickerFechaFac.Text);
                    objetoFactura.codcliente = Convert.ToInt32(comboBoxCodCliente.SelectedValue.ToString());
                    objetoFactura.codempleado = Convert.ToInt32(comboBoxCodEmpleado.SelectedValue.ToString());
                    
                    if (logicaNF.insertarFacturas(objetoFactura)>0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewFactura.DataSource = logicaNF.listarFacturas();
                        dateTimePickerFechaFac.Text = "";
                        comboBoxCodCliente.Text = "";
                        comboBoxCodEmpleado.Text = "";
                        tabFactura.SelectedTab = tabPage2;
                    }

                    else
                    {
                        MessageBox.Show("Error al agregar factura");
                    }

                    buttonGuardar.Text = "Guardar";
                }
  
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void FFactura_Load(object sender, EventArgs e)
        {
            textBoxCodFac.Visible = false;
            labelcodigofac.Visible= false;
            List <Clientes> clien = new List <Clientes>();
            clien = logicaNCL.listarClientes();
            List<Empleados> emple = new List<Empleados>();
            emple = logicaNEM.listarEmpleados();
            comboBoxCodCliente.ValueMember = "codcliente";
            comboBoxCodCliente.DisplayMember = "nombrescli";
            comboBoxCodCliente.DataSource = clien;
            comboBoxCodEmpleado.ValueMember = "codempleado";
            comboBoxCodEmpleado.DisplayMember = "nombre_emple";
            comboBoxCodEmpleado.DataSource = emple;
            dataGridViewFactura.DataSource = logicaNF.listarFacturas();
        }

        private void textBoxBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            List<Factura> listaFactura = logicaNF.BuscarFacturas(textBoxBuscarFactura.Text);
            dataGridViewFactura.DataSource = listaFactura;
        }
    }
}
