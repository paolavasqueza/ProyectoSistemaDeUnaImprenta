using entidadesimprenta;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sistema_imprenta
{
    public partial class Listadeproductos : Form
    {
        public Listadeproductos()
        {
            InitializeComponent();
        }

        string operacion = "";
        Producto producto;
        BindingList<Producto> listaProductos = new BindingList<Producto>();


        private void HabilitarControles()
        {

            textBoxcliente.Enabled = true;
            comboBoxproducto.Enabled = true;
            comboBoxtamaño.Enabled = true;
            textBoxentrega.Enabled = true;
            textBoxprecio.Enabled = true;


        }

        private void DesabilitarControles()
        {

            textBoxcliente.Enabled = false;
            comboBoxproducto.Enabled = false;
            comboBoxtamaño.Enabled = false;
            textBoxentrega.Enabled = false;
            textBoxprecio.Enabled = false;


        }

        private void LimpiarControles()
        {

            textBoxcliente.Clear();
            comboBoxproducto.Text = string.Empty;
            comboBoxtamaño.Text = string.Empty;
            textBoxentrega.Clear();
            textBoxprecio.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";

        }
        private void LlenarDataGrid()
        {

            productosdataGridView.DataSource = null;
            productosdataGridView.DataSource = listaProductos;
        }
        private void Listadeproductos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (productosdataGridView.SelectedRows.Count > 0)
            {
                foreach (Producto prod in listaProductos)
                {
                    if (prod.Cliente == productosdataGridView.CurrentRow.Cells["cliente"].Value.ToString())
                    {
                        listaProductos.Remove(prod);
                        break;
                    }
                }
                LlenarDataGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxcliente.Text == String.Empty)
            {
                errorProvider1.SetError(textBoxcliente, "Ingrese el cliente");
                textBoxcliente.Focus();
                return;
            }

            //Instanciamos el objeto de Producto

            producto = new Producto(comboBoxproducto.Text, comboBoxtamaño.Text,
                                Convert.ToInt32(textBoxentrega.Text), Convert.ToDecimal(textBoxprecio.Text));

            if (operacion == "Nuevo")
            {
                listaProductos.Add(producto);
                LlenarDataGrid();

                DesabilitarControles();
                LimpiarControles();
            }
            else if (operacion == "Modificar")
            {
                foreach (Producto prod in listaProductos)
                {
                    if (comboBoxproducto.Text == prod.Productos)
                    {
                        prod.Cliente = textBoxcliente.Text;
                        prod.DiasdeEntrega = Convert.ToInt32(textBoxentrega.Text);
                        prod.Precio = Convert.ToDecimal(textBoxprecio.Text);
                        break;
                    }
                }
                LlenarDataGrid();
                LimpiarControles();
                DesabilitarControles();
            }
        }

        private void textBoxcliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}