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
    public partial class FClientes : Form
    {
        logicaNegocioClientes logicaNCLI = new logicaNegocioClientes();

        public FClientes()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text =="Guardar")
                {

                    Clientes objetoClientes = new Clientes();
                    objetoClientes.cedulacl = textBoxCedulaCli.Text;
                    objetoClientes.nombrescli = textBoxNombreCli.Text;
                    objetoClientes.apellidos = textBoxApellidoCli.Text;
                    objetoClientes.direccion = textBoxDireccionCli.Text;
                    objetoClientes.telefono = textBoxTelefonoCli.Text;
                    objetoClientes.correo_cli = textBoxCorreoCli.Text;

                    if (logicaNCLI.insertarCliente(objetoClientes)>0)
                    {
                        MessageBox.Show("Agregado con éxito!!");
                        dataGridViewClientes.DataSource = logicaNCLI.listarClientes();
                        textBoxCedulaCli.Text = "";
                        textBoxNombreCli.Text = "";
                        textBoxApellidoCli.Text = "";
                        textBoxDireccionCli.Text = "";
                        textBoxTelefonoCli.Text = "";
                        textBoxCorreoCli.Text = "";
                        tabControlClientes.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar cliente");
                    }
                }

                if (buttonGuardar.Text=="Actualizar")
                {
                    Clientes objetoClientes = new Clientes();
                    objetoClientes.codcliente = Convert.ToInt32(textBoxCodigoCli.Text);
                    objetoClientes.cedulacl = textBoxCedulaCli.Text;
                    objetoClientes.nombrescli = textBoxNombreCli.Text;
                    objetoClientes.apellidos = textBoxApellidoCli.Text;
                    objetoClientes.direccion = textBoxDireccionCli.Text;
                    objetoClientes.telefono = textBoxTelefonoCli.Text;
                    objetoClientes.correo_cli = textBoxCorreoCli.Text;

                    if (logicaNCLI.editarClientes(objetoClientes)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewClientes.DataSource = logicaNCLI.listarClientes();
                        textBoxCedulaCli.Text = "";
                        textBoxNombreCli.Text = "";
                        textBoxApellidoCli.Text = "";
                        textBoxDireccionCli.Text = "";
                        textBoxTelefonoCli.Text = "";
                        textBoxCorreoCli.Text = "";
                        tabControlClientes.SelectedTab = tabPage2;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar cliente");
                    }

                    buttonGuardar.Text = "Guardar";
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void FClientes_Load(object sender, EventArgs e)
        {
            textBoxCodigoCli.Visible = false;
            labelCod.Visible = false;
            dataGridViewClientes.DataSource = logicaNCLI.listarClientes();
        }

        private void buttonEditarCli_Click(object sender, EventArgs e)
        {
            textBoxCodigoCli.Visible = true;
            textBoxCodigoCli.Enabled = false;
            labelCod.Visible = true;

            textBoxCodigoCli.Text = dataGridViewClientes.CurrentRow.Cells["codcliente"].Value.ToString();
            textBoxNombreCli.Text = dataGridViewClientes.CurrentRow.Cells["nombrescli"].Value.ToString();
            textBoxApellidoCli.Text = dataGridViewClientes.CurrentRow.Cells["apellidos"].Value.ToString();
            textBoxDireccionCli.Text = dataGridViewClientes.CurrentRow.Cells["direccion"].Value.ToString();
            textBoxTelefonoCli.Text = dataGridViewClientes.CurrentRow.Cells["telefono"].Value.ToString();
            textBoxCorreoCli.Text = dataGridViewClientes.CurrentRow.Cells["correo_cli"].Value.ToString();

            tabControlClientes.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminarCli_Click(object sender, EventArgs e)
        {
            int codigoCLI = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["codcliente"].Value.ToString());
            try
            {
                if (logicaNCLI.eliminarCliente(codigoCLI)>0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewClientes.DataSource = logicaNCLI.listarClientes();
                }
            }
            catch 
            {
                MessageBox.Show("Error al eliminar cliente");
            }
        }

        private void textBoxBuscarCL_TextChanged(object sender, EventArgs e)
        {
            List<Clientes> listaClientes = logicaNCLI.BuscarClientes(textBoxBuscarCL.Text);
            dataGridViewClientes.DataSource = listaClientes;
        }
    }
}
