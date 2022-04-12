using Datos.Conexiones;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BufeteDeAbogados
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuariosConexion usuarioAcceso = new UsuariosConexion();
            Usuarios usuario = new Usuarios();

            usuario = usuarioAcceso.Login(textBoxCodigo.Text, textBoxContraseña.Text);

            if (usuario == null)
            {
                MessageBox.Show("El usuario no existe");
                textBoxCodigo.Clear();
                textBoxContraseña.Clear();
                textBoxCodigo.Focus();
                return;
            }
            MessageBox.Show("Bienvenidos");

            //FrmMenu frmMenu = new FrmMenu();
            //frmMenu.Show();
            //this.Hide();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
