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
    public partial class frmFinanzas : Form
    {
        decimal varDeposito = 0, varAlquiler = 0, varImpuestos = 0, varSalidas = 0, varComida = 0, varGastos = 0;
        public frmFinanzas()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            varDeposito = decimal.Parse(txtDeposito.Text);
            varAlquiler = decimal.Parse(txtAlquiler.Text);
            varImpuestos = decimal.Parse(txtImpuestos.Text);
            varSalidas = decimal.Parse(txtSalidas.Text);
            varComida = decimal.Parse(txtComida.Text);
            varGastos = decimal.Parse(txtGastoFijo.Text);
            decimal total = varDeposito - varAlquiler - varImpuestos - varSalidas - varComida - varGastos;
            lblTotal.Text = total.ToString();
        }
    }
}
