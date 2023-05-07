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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void cmdComida_Click(object sender, EventArgs e)
        {
            frmListado lista = new frmListado("Comida");
            lista.ShowDialog();
        }

        private void cmdFrio_Click(object sender, EventArgs e)
        {
            frmListado lista = new frmListado("Frio");
            lista.ShowDialog();
        }

        private void cmdLimpieza_Click(object sender, EventArgs e)
        {
            frmListado lista = new frmListado("Limpieza");
            lista.ShowDialog();
        }

        private void cmdBano_Click(object sender, EventArgs e)
        {
            frmListado lista = new frmListado("Baño");
            lista.ShowDialog();
        }

        private void cmdVerTodo_Click(object sender, EventArgs e)
        {
            frmListado lista = new frmListado("Listado");
            lista.ShowDialog();
        }
    }
}
