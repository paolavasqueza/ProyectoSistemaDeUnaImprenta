using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidadesimprenta;


namespace sistema_imprenta
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        Usuario user;
        string _codigoUsuario ="IMPRENTA";
        string _Clave ="2022";
        int contador = 0;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            contador=contador+1;
            if(contador== 3)
            {
                MessageBox.Show("3 intentos fallidos", "la aplicacion se cerrara", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if (CodigotextBox.Text == "")
            {
                errorProvider1.SetError(CodigotextBox, "Ingrese un Codigo");
                CodigotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ClavetextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ClavetextBox, "Ingrese una contraseña");
                ClavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            user = new Usuario(CodigotextBox.Text, ClavetextBox.Text);

            if (user.codigo.ToUpper() == _codigoUsuario && user.Clave == _Clave)
            {
                Menu mainMenu = new Menu();
                Hide();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos" , "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
