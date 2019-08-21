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


namespace capaPresentacionWF
{
    public partial class MDIInventario : Form
    {

        logicaNegocioRespaldo lN = new logicaNegocioRespaldo();
        private int childFormNumber = 0;

        public MDIInventario()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = facturaToolStripMenuItem.Checked;
        }

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FProductos"] != null)
            {
                Application.OpenForms["FProductos"].Activate();
            }
            else
            {
                FProductos fp= new FProductos();
                fp.MdiParent = this;
                fp.Show();
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Fcategoria"] != null)
            {
                Application.OpenForms["Fcategoria"].Activate();
            }
            else
            {
                Fcategoria fc = new Fcategoria();
                fc.MdiParent = this;
                fc.Show();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FProveedores"] != null)
            {
                Application.OpenForms["FProveedores"].Activate();
            }
            else
            {
                FProveedores fv = new FProveedores();
                fv.MdiParent = this;
                fv.BringToFront();
                fv.Show();
            }
        }

        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FClientes"]!= null)
            {
                Application.OpenForms["FClientes"].Activate();
            }
            else
            {
                FClientes fcl = new FClientes();
                fcl.MdiParent = this;
                fcl.Show();
            }
        }

        private void VentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FVentas"] != null)
            {
                Application.OpenForms["FVentas"].Activate();
            }
            else
            {
                FVentas fve = new FVentas();
                fve.MdiParent = this;
                fve.Show();
            }
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FFactura"] != null)
            {
                Application.OpenForms["FFactura"].Activate();
            }
            else
            {
                FFactura ffa = new FFactura();
                ffa.MdiParent = this;
                ffa.Show();
            }
        }

        private void empleadosToolStripMenuItem_Clicl(object sender, EventArgs e)
        {
            if (Application.OpenForms["FEmpleado"] != null)
            {
                Application.OpenForms["FEmpleado"].Activate();
            }
            else
            {
                FEmpleado fe = new FEmpleado();
                fe.MdiParent = this;
                fe.Show();
            }
        }

        private void fileSalir_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation()== System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }
        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("¿Está seguro de que quiere cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        //private void respaldoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (lN.respaldarBD() > 0)
        //        {
        //            MessageBox.Show("Respaldo realizado con éxito");
        //        }

        //    }
        //    catch { MessageBox.Show("Error al realizar el respaldo"); }
           
            
        //}

        private void fileMantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void respaldoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void respaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lN.respaldarBD() > 0)
                {
                    MessageBox.Show("Respaldo realizado con éxito");
                }

            }
            catch { MessageBox.Show("Error al realizar el respaldo"); }
           
        }
    }
}
