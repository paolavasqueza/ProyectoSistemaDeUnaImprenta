using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_imprenta
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void invetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios users = new Usuarios();
            users.Show();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listadeclientes client = new Listadeclientes();
            client.Show();

        }

        private void listaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listadeproductos products = new Listadeproductos();
            products.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura bill = new Factura();
            bill.Show();    
        }
    }
}
