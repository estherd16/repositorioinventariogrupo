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
    public partial class FVentas : Form
    {
        logicaNegocioVentas logicaNV = new logicaNegocioVentas();
        logicaNegocioProductos logicaNPR = new logicaNegocioProductos();
        logicaNegocioFactura logicaNFA = new logicaNegocioFactura();

        public FVentas()
        {
            InitializeComponent();
        }

        private void buttonGuardarVen_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardarVen.Text=="Guardar")
                {
                    Ventas objetoVentas = new Ventas();
                    objetoVentas.cantidad = Convert.ToInt32(textBoxcantidad.Text);
                    objetoVentas.precio = Convert.ToInt32(textBoxprecio.Text);
                    objetoVentas.codproducto = Convert.ToInt32(comboBoxcodprod.Text);
                    objetoVentas.idFactura = Convert.ToInt32(comboBoxcodfact.Text);

                    if (logicaNV.insertarVenta(objetoVentas)>0)
                    {
                        dataGridViewVentas.DataSource = logicaNV.listarVentas();
                        textBoxcantidad.Text = "";
                        textBoxprecio.Text = "";
                        comboBoxcodprod.Text = "";
                        comboBoxcodfact.Text = "";
                        tabVentas.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar venta");
                    }

                    buttonGuardarVen.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void FVentas_Load(object sender, EventArgs e)
        {
            textBoxcodven.Visible = true;
            textBoxcodven.Enabled = false;
            labelcodigo.Visible = true;
            
            List<int> prod = new List<int>();
            prod = logicaNPR.listarProductos().Select(x => x.codproducto).ToList();

            List<int> fac = new List<int>();
            fac = logicaNFA.listarFacturas().Select(x => x.idFactura).ToList();

            comboBoxcodprod.DataSource = prod;
            comboBoxcodfact.DataSource = fac;

            dataGridViewVentas.DataSource = logicaNV.listarVentas();


        }

        private void textBoxBuscarVenta_TextChanged(object sender, EventArgs e)
        {
            List<Ventas> listaVentas = logicaNV.BuscarVentas(textBoxBuscarVenta.Text);
            dataGridViewVentas.DataSource = listaVentas;
        }
    }
}
