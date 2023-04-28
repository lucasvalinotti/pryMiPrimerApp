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

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procuto agregado con Exito!", "Producto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nmcCantidad.Value = 0; txtProducto.Clear();
        }
    }
}
