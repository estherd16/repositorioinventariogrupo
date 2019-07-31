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
    public partial class FEmpleado : Form
    {
        logicaNegocioEmpleados logicaEM = new logicaNegocioEmpleados();

        public FEmpleado()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTelefonoCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDireccionCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text=="Guardar")
                {
                    Empleados objetoEmpleados = new Empleados();
                    objetoEmpleados.cedulaempleado = textBoxCedulaEM.Text;
                    objetoEmpleados.nombre_emple = textBoxNombreEM.Text;
                    objetoEmpleados.apellidoemple = textBoxApellidoEM.Text;
                    objetoEmpleados.telefonoempl = textBoxTelefonoEM.Text;
                    objetoEmpleados.direccionempl = textBoxDireccionEM.Text;
                    objetoEmpleados.correoemple = textBoxCorreoEM.Text;
                                        
                    if (logicaEM.insertarEmpleados(objetoEmpleados)>0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewEMPLE.DataSource = logicaEM.listarEmpleados();
                        textBoxCedulaEM.Text = "";
                        textBoxNombreEM.Text= "";
                        textBoxApellidoEM.Text = "";
                        textBoxTelefonoEM.Text = "";
                        textBoxDireccionEM.Text = "";
                        textBoxCorreoEM.Text = "";
                        tabEmpleados.SelectedTab = tabPage2;
                    }

                    else
                    {
                        MessageBox.Show("Error al agregar empleado");
                    }
                }
                if (buttonGuardar.Text=="Actualizar")
                {
                    Empleados objetoEmpleados = new Empleados();
                    objetoEmpleados.codempleado = Convert.ToInt32(textBoxCodigoEmpl.Text);
                    objetoEmpleados.cedulaempleado = textBoxCedulaEM.Text;
                    objetoEmpleados.nombre_emple = textBoxNombreEM.Text;
                    objetoEmpleados.apellidoemple = textBoxApellidoEM.Text;
                    objetoEmpleados.telefonoempl = textBoxTelefonoEM.Text;
                    objetoEmpleados.direccionempl = textBoxDireccionEM.Text;
                    objetoEmpleados.correoemple = textBoxCorreoEM.Text;

                    if (logicaEM.editarEmpleados(objetoEmpleados)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewEMPLE.DataSource = logicaEM.listarEmpleados();
                        textBoxCedulaEM.Text = "";
                        textBoxNombreEM.Text = "";
                        textBoxApellidoEM.Text = "";
                        textBoxTelefonoEM.Text = "";
                        textBoxDireccionEM.Text = "";
                        textBoxCorreoEM.Text = "";
                        tabEmpleados.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar empleado");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void textBoxCorreoCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxApellidoCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCedulaCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FEmpleado_Load(object sender, EventArgs e)
        {
            textBoxCodigoEmpl.Visible = false;
            labelcodigo.Visible = false;
            dataGridViewEMPLE.DataSource = logicaEM.listarEmpleados();
        }

        private void buttonEditarEM_Click(object sender, EventArgs e)
        {
            textBoxCodigoEmpl.Visible = true;
            textBoxCodigoEmpl.Enabled = false;
            labelcodigo.Visible = true;

            textBoxCodigoEmpl.Text = dataGridViewEMPLE.CurrentRow.Cells["codempleado"].Value.ToString();
            textBoxCedulaEM.Text = dataGridViewEMPLE.CurrentRow.Cells["cedulaempleado"].Value.ToString();
            textBoxNombreEM.Text = dataGridViewEMPLE.CurrentRow.Cells["nombre_emple"].Value.ToString();
            textBoxApellidoEM.Text = dataGridViewEMPLE.CurrentRow.Cells["apellidoemple"].Value.ToString();
            textBoxTelefonoEM.Text = dataGridViewEMPLE.CurrentRow.Cells["telefonoempl"].Value.ToString();
            textBoxDireccionEM.Text = dataGridViewEMPLE.CurrentRow.Cells["direccionempl"].Value.ToString();
            textBoxCorreoEM.Text = dataGridViewEMPLE.CurrentRow.Cells["correoemple"].Value.ToString();

            tabEmpleados.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminarEM_Click(object sender, EventArgs e)
        {
            int codigoEMPLE = Convert.ToInt32(dataGridViewEMPLE.CurrentRow.Cells["codempleado"].Value.ToString());

            try
            {
                if (logicaEM.eliminarEmpleados(codigoEMPLE)>0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewEMPLE.DataSource = logicaEM.listarEmpleados();
                }
            }
            catch 
            {
                MessageBox.Show("Error al eliminar empleado");
            }

        }

        private void textBoxBuscarEM_TextChanged(object sender, EventArgs e)
        {
            List<Empleados> listaEmpleados = logicaEM.BuscarEmpleado(textBoxBuscarEM.Text);
            dataGridViewEMPLE.DataSource = listaEmpleados;

        }
    }
}
