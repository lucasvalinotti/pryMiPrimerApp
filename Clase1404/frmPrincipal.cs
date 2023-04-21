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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdFinanzas_Click(object sender, EventArgs e)
        {
            frmFinanzas finanzas = new frmFinanzas();
            finanzas.ShowDialog();
        }

        private void cmdAlmacen_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();  
            inventario.ShowDialog();
        }
    }
}
