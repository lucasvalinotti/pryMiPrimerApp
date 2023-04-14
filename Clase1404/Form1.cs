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

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            float total = float.Parse(txtDeposito.Text) - (float.Parse(txtAlquiler.Text) + float.Parse(txtImpuestos.Text) +
                float.Parse(txtSalidas.Text) + float.Parse(txtComida.Text) + float.Parse(txtGastoFijo.Text));

            lblTotal.Text = total.ToString();
        }
    }
}
