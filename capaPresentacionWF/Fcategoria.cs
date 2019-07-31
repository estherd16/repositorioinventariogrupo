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
    public partial class Fcategoria : Form
    {
        logicaNegocioCategoria logicaNCAT = new logicaNegocioCategoria();
        public Fcategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Categoria objetoCategoria = new Categoria();
                    objetoCategoria.nombrecat = textBoxNomCat.Text;
                    objetoCategoria.descripcion = textBoxDesCat.Text;

                    if (logicaNCAT.insertarCategoria(objetoCategoria)>0)
                    {
                        MessageBox.Show("agregado con éxito");
                        dataGridViewCategoria.DataSource = logicaNCAT.listarCategoria();
                        textBoxNomCat.Text = "";
                        textBoxDesCat.Text = "";
                        tabCategoria.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar categoria");
                    }
                }

                if (buttonGuardar.Text =="Actualizar")
                {
                    Categoria objetoCategoria = new Categoria();
                    objetoCategoria.codcategoria = Convert.ToInt32(textBoxidCat.Text);
                    objetoCategoria.nombrecat = textBoxNomCat.Text;
                    objetoCategoria.descripcion = textBoxDesCat.Text;

                    if (logicaNCAT.editarCategoria(objetoCategoria)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewCategoria.DataSource = logicaNCAT.listarCategoria();
                        textBoxNomCat.Text = "";
                        textBoxDesCat.Text = "";
                        tabCategoria.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar categoria");
                    }
                    buttonGuardar.Text = "Guardar";
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void Fcategoria_Load(object sender, EventArgs e)
        {
            textBoxidCat.Visible = false;
            labelid.Visible = false;
            dataGridViewCategoria.DataSource = logicaNCAT.listarCategoria();
        }

        private void buttoneditar_Click(object sender, EventArgs e)
        {
            textBoxidCat.Visible = true;
            textBoxidCat.Enabled = false;
            labelid.Visible = true;

            textBoxidCat.Text = dataGridViewCategoria.CurrentRow.Cells["codcategoria"].Value.ToString();
            textBoxNomCat.Text = dataGridViewCategoria.CurrentRow.Cells["nombrecat"].Value.ToString();
            textBoxDesCat.Text = dataGridViewCategoria.CurrentRow.Cells["descripcion"].Value.ToString();

            tabCategoria.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";
        }

        private void buttonEliminarCat_Click(object sender, EventArgs e)
        {
            int codigoCat = Convert.ToInt32(dataGridViewCategoria.CurrentRow.Cells["codcategoria"].Value.ToString());
            try
            {
                if (logicaNCAT.eliminarCategoria(codigoCat)>0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewCategoria.DataSource = logicaNCAT.listarCategoria();
                }
            }
            catch 
            {
                MessageBox.Show("Error al eliminar categoria");
            }
        }

        private void textBoxBuscarCat_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaCategoria = logicaNCAT.buscarCategoria(textBoxBuscarCat.Text);
            dataGridViewCategoria.DataSource = listaCategoria;
        }
    }
}
