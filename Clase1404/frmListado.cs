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
        Producto producto;
        string titulo;

        public frmListado(string encabezado)
        {
            titulo = encabezado;
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            this.Text = titulo;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            frmAgregar agg = new frmAgregar();
            productos.Add(producto);
            MessageBox.Show(productos.Count().ToString());
            dgvProductos.DataSource = productos;
        }
    }
}
