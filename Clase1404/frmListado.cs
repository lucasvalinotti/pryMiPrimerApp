using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1404
{
    public partial class frmListado : Form
    {
        public List<Producto> productos = new List<Producto>();
        string titulo;

        public frmListado(string encabezado)
        {
            titulo = encabezado;
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            this.Text = titulo;
            dgvProductos.Columns.Add("Producto", "Producto");
            dgvProductos.Columns.Add("Categoria", "Categoria");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Caduca", "Caduca");
            dgvProductos.Columns.Add("Vencimiento", "Vencimiento");
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            
            Producto producto = new Producto(txtProducto.Text, lstCategoria.Text, nmcCantidad.Value, "Caduca", dtpVencimiento.Value.ToString("dd/MM/yyyy"));
            if (chkCaduca.Checked == false)
            {
                producto.Caduca = "No";
                producto.fechaVencimiento = "--/--/--";
            }
            else
            {
                producto.Caduca = "Si";
            }
            //productos.Add(producto);
            dgvProductos.Rows.Add(producto.Nombre, producto.Tipo, producto.Cantidad, producto.Caduca, producto.fechaVencimiento);
        }

        private void chkCaduca_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaduca.Checked == true)
            {
                dtpVencimiento.Enabled = true;
            }
            else
            {
                dtpVencimiento.Enabled=false;
            }
        }
    }
}
