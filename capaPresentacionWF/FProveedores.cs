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
    public partial class FProveedores : Form
    {
        logicaNegocioProveedores logicaNPROV = new logicaNegocioProveedores();
        public FProveedores()
        {
            InitializeComponent();
        }

        private void buttonGuardarprov_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardarprov.Text=="Guardar")
                {
                  Proveedores objetoProveedor = new Proveedores();
                  objetoProveedor.nombreprov = textBoxnombreprov.Text;
                  objetoProveedor.ruc = textBoxRUC.Text;
                  objetoProveedor.telefono = textBoxtelefprov.Text;
                  objetoProveedor.direccion = textBoxdireccionprov.Text;
                  objetoProveedor.correoprov = textBoxcorreoprov.Text;

                 if (logicaNPROV.insertarProveedores(objetoProveedor)>0)
                 {
                     MessageBox.Show("Agregado con éxito");
                     dataGridViewProveedor.DataSource = logicaNPROV.listarProveedores();
                     textBoxRUC.Text = "";
                     textBoxnombreprov.Text="";
                     textBoxtelefprov.Text= "";
                     textBoxdireccionprov.Text ="";
                     textBoxcorreoprov.Text ="";
                     tabProveedor.SelectedTab = tabPage2;
	              }
                    else { MessageBox.Show("Error al agregar Proveedor"); }
              }
                if (buttonGuardarprov.Text =="Actualizar")
	            {
                    Proveedores objetoProveedor = new Proveedores();
		            objetoProveedor.codproveedor= Convert.ToInt32(textBoxcodprov.Text);
                    objetoProveedor.ruc = textBoxRUC.Text;
                    objetoProveedor.nombreprov =textBoxnombreprov.Text;
                    objetoProveedor.telefono=textBoxtelefprov.Text;
                    objetoProveedor.direccion=textBoxdireccionprov.Text;
                    objetoProveedor.correoprov=textBoxcorreoprov.Text;
                     
                    if (logicaNPROV.editarProveedores(objetoProveedor)>0)
	                {
		                MessageBox.Show("Actualizado con éxito");
                        dataGridViewProveedor.DataSource=logicaNPROV.listarProveedores();
                        textBoxRUC.Text = "";
                        textBoxnombreprov.Text= "";
                        textBoxtelefprov.Text ="";
                        textBoxdireccionprov.Text ="";
                        textBoxcorreoprov.Text ="";
                        tabProveedor.SelectedTab = tabPage2;

	                 }
                    else 
                    {
                        MessageBox.Show("Error al actualizar");
                    }
                    buttonGuardarprov.Text = "Guardar";
                }
            }
            catch
            {
              MessageBox.Show("ERROR");   
            }

        }

        private void FProveedores_Load(object sender, EventArgs e)
        {
            textBoxcodprov.Visible = false;
            labelcod.Visible = false;
            dataGridViewProveedor.DataSource = logicaNPROV.listarProveedores();

        }

        private void buttonEditarProveedor_Click(object sender, EventArgs e)
        {
            textBoxcodprov.Text = dataGridViewProveedor.CurrentRow.Cells["codproveedor"].Value.ToString();
            textBoxRUC.Text = dataGridViewProveedor.CurrentRow.Cells["ruc"].Value.ToString();
            textBoxnombreprov.Text = dataGridViewProveedor.CurrentRow.Cells["nombreprov"].Value.ToString();
            textBoxdireccionprov.Text = dataGridViewProveedor.CurrentRow.Cells["direccion"].Value.ToString();
            textBoxtelefprov.Text = dataGridViewProveedor.CurrentRow.Cells["telefono"].Value.ToString();
            textBoxcorreoprov.Text = dataGridViewProveedor.CurrentRow.Cells["correoprov"].Value.ToString();

            tabProveedor.SelectedTab = tabPage1;
            buttonGuardarprov.Text = "Actualizar";
        }

        private void buttonEliminarProveedor_Click(object sender, EventArgs e)
        {
            int codigoR = Convert.ToInt32(dataGridViewProveedor.CurrentRow.Cells["codproveedor"].Value.ToString());
            try
            {
                if (logicaNPROV.eliminarProveedor(codigoR) > 0) 
                {
                    MessageBox.Show("Eliminado con éxito!");
                    dataGridViewProveedor.DataSource = logicaNPROV.listarProveedores();
                }
            }
            catch 
            {

                MessageBox.Show("ERROR al eliminar");
            }
        }

        private void textBoxBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            List<Proveedores> listaProveedor = logicaNPROV.BuscarProveedores(textBoxBuscarProveedor.Text);
            dataGridViewProveedor.DataSource = listaProveedor;
        }
    }
}
    

