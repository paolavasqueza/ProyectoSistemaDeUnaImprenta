using System;
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

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void listaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listadeproductos Listadeproductos = new Listadeproductos();
            Listadeproductos.Show();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listadeclientes ListClient = new Listadeclientes();
            ListClient.Show();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura Bill = new Factura();
            Bill.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
