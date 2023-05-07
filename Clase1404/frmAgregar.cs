using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1404
{
    public partial class frmAgregar : Form
    {
        Producto producto = null;

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {

            //producto = new Producto(txtProducto.Text, lstCategoria.Text, nmcCantidad.Value, chkCaduca.Checked, dtpVencimiento.Value);


            frmListado listado = new frmListado("");

            listado.dgvProductos.Columns.Add("Producto", "Producto");
            listado.dgvProductos.Columns.Add("Categoria", "Categoria");
            listado.dgvProductos.Columns.Add("Cantidad", "Cantidad");
            listado.dgvProductos.Columns.Add("Caduca", "Caduca");
            listado.dgvProductos.Columns.Add("Vencimiento", "Vencimiento");

            listado.dgvProductos.Rows.Add(txtProducto.Text, lstCategoria.Text, nmcCantidad.Value, chkCaduca.Checked, dtpVencimiento.Value);


            listado.ShowDialog();

            //listado.productos.Add(producto);
            MessageBox.Show("Se agrego el producto: " + producto.Nombre, "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nmcCantidad.Value = 0; txtProducto.Clear();
            
            //this.Close();

            
        }

        private void chkCaduca_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaduca.Checked == true)
            {
                dtpVencimiento.Enabled = true;
            }
            else
            {
                dtpVencimiento.Enabled = false;
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            producto = new Producto();

        }
    }
}
