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
    public partial class frmListado : Form
    {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
        }
    }
}
