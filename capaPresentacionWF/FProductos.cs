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
using capaDatos;

namespace capaPresentacionWF
{
    public partial class FProductos : Form
    {
        logicaNegocioProductos logicaNProd = new logicaNegocioProductos();
        logicaNegocioCategoria logicaNCAT = new logicaNegocioCategoria();
        logicaNegocioProveedores logicaNPROVE = new logicaNegocioProveedores();


        public FProductos()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Productos objetoProductos = new Productos();
                    objetoProductos.producto = textBoxNombreproducto.Text;
                    objetoProductos.precio = Convert.ToInt32(textBoxPrecioprod.Text);
                    objetoProductos.existencia = Convert.ToInt32(textBoxexistencia.Text);
                    objetoProductos.codcategoria = Convert.ToInt32(comboBoxcodcat.Text);
                    objetoProductos.codproveedor = Convert.ToInt32(comboBoxcodprov.Text);
                 
                    if (logicaNProd.insertarProductos(objetoProductos) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewProducto.DataSource = logicaNProd.listarProductos();
                        textBoxNombreproducto.Text = "";
                        textBoxPrecioprod.Text = "";
                        textBoxexistencia.Text = "";
                        comboBoxcodcat.Text = "";
                        comboBoxcodprov.Text = "";
                        tabProductos.SelectedTab = tabPage2;
                                               
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar producto");
                    }

                }

                if (buttonGuardar.Text == "Actualizar")
                {
                    Productos objetoProductos = new Productos();
                    objetoProductos.codproducto = Convert.ToInt32(textBoxcodproducto.Text);
                    objetoProductos.producto = textBoxNombreproducto.Text;
                    objetoProductos.precio = Convert.ToInt32(textBoxPrecioprod.Text);
                    objetoProductos.existencia = Convert.ToInt32(textBoxexistencia.Text);
                    objetoProductos.codcategoria = Convert.ToInt32(comboBoxcodcat.Text);
                    objetoProductos.codproveedor = Convert.ToInt32(comboBoxcodprov.Text);
                    
                    
                    if (logicaNProd.editarProductos(objetoProductos)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewProducto.DataSource = logicaNProd.listarProductos();
                        textBoxNombreproducto.Text = "";
                        textBoxPrecioprod.Text = "";
                        textBoxexistencia.Text = "";
                        comboBoxcodcat.Text = "";
                        comboBoxcodprov.Text = "";
                        tabProductos.SelectedTab = tabPage2;

                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar producto");
                    }
                    buttonGuardar.Text = "Guardar";
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void FProductos_Load(object sender, EventArgs e)
        {
            textBoxcodproducto.Visible = false;
            labelcodigo.Visible = false;



            List<int> categ = new List<int>();
            categ = logicaNCAT.listarCategoria().Select(x => x.codcategoria).ToList();
            List<int> prov = new List<int>();
            prov = logicaNPROVE.listarProveedores().Select(x => x.codproveedor).ToList();

            comboBoxcodcat.DataSource = categ;
            comboBoxcodprov.DataSource = prov;
            dataGridViewProducto.DataSource = logicaNProd.listarProductos();

        }

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {
            textBoxcodproducto.Visible = true;
            textBoxcodproducto.Enabled = false;
            labelcodigo.Visible = true;

            comboBoxcodcat.Visible = true;
            comboBoxcodcat.Enabled = false;
            labelcodcate.Visible = true;
            comboBoxcodprov.Visible = true;
            comboBoxcodprov.Enabled = false;
            labelcodprov.Visible = true;

            textBoxcodproducto.Text = dataGridViewProducto.CurrentRow.Cells["codproducto"].Value.ToString();
            textBoxNombreproducto.Text = dataGridViewProducto.CurrentRow.Cells["producto"].Value.ToString();
            textBoxPrecioprod.Text = dataGridViewProducto.CurrentRow.Cells["precio"].Value.ToString();
            textBoxexistencia.Text = dataGridViewProducto.CurrentRow.Cells["existencia"].Value.ToString();
            comboBoxcodcat.Text = dataGridViewProducto.CurrentRow.Cells["codcategoria"].Value.ToString();
            comboBoxcodprov.Text = dataGridViewProducto.CurrentRow.Cells["codproveedor"].Value.ToString();

            tabProductos.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminarProducto_Click(object sender, EventArgs e)
        {
            int codigoPROD = Convert.ToInt32(dataGridViewProducto.CurrentRow.Cells["codproducto"].Value.ToString());
            try
            {
                if (logicaNProd.eliminarProductos(codigoPROD)>0)
                {
                    MessageBox.Show("Eliminado");
                    dataGridViewProducto.DataSource = logicaNProd.listarProductos();
                }
            }
            catch 
            {
                MessageBox.Show("Error al eliminar producto");
            }
        }

        private void textBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            List<Productos> listaProductos = logicaNProd.BuscarProductos(textBoxBuscarProducto.Text);
            dataGridViewProducto.DataSource = listaProductos;
        }
    }
}
