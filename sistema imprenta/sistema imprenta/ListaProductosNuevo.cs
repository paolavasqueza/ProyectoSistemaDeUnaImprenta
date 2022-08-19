using System;
using entidadesimprenta;
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
    public partial class ListaProductosNuevo : Form
    {
        public ListaProductosNuevo()
        {
            InitializeComponent();
        }

        string operation = string.Empty;
        BindingList<Producto> ListaProductos = new BindingList<Producto>();

        private void ListarProductos()
        {
            productosdataGridView.DataSource = ListaProductos;
        }

        private void HabilitarControles()
        {
            textBoxcliente.Enabled = true;
            textBoxentrega.Enabled = true;
            textBoxprecio.Enabled = true;
            textBoxtamaño.Enabled = true;
            textBoxProducto.Enabled = true;
            textBoxtam.Enabled = true;
        }
        private void LimpiarControles()
        {
            textBoxcliente.Clear();
            textBoxentrega.Clear();
            textBoxprecio.Clear();
            textBoxtamaño.Clear();
            textBoxProducto.Clear();
            textBoxtam.Clear();
        }
        private void DeshabilitarControles()
        {
            textBoxcliente.Enabled = false;
            textBoxentrega.Enabled = false;
            textBoxprecio.Enabled = false;
            textBoxtamaño.Enabled = false;
            textBoxProducto.Enabled = false;
            textBoxtam.Enabled = false;
        }

        private void agregarbutton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operation = "Nuevo";
        }

        private void ListaProductosNuevo_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
