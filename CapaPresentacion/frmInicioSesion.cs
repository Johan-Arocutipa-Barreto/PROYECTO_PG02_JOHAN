using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInicioSesion : Form
    {
        private clsCredenciales_CN ObjCredenciales = new clsCredenciales_CN();

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string clave = txtContraseña.Text;

            //VERIFICAR QUE NO SE INGRESEN
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("No puede dejar espacios en blanco");
                return;
            }

            try
            {
                bool ValidarCredencial = ObjCredenciales.mtdCValidarCredencialesCN(correo, clave); //VERIFICAR SI LAS CREDENCIALES SON CORRECTAS
                var GuardarUsuario = ObjCredenciales.mtdObtenerUsuarioCN(correo, clave); //GUARDAR LA INFORMACION DEL USUARIO PARA EL USO DEL SISTEMA

                if (ValidarCredencial)
                {
                    MessageBox.Show("Credenciales Correctas", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //GUADAR EL USUARIO EN UNA CLASE GLOBAL STATIC
                    clsSesionUsuario_CN.idUsuario = GuardarUsuario.idUsuario;
                    clsSesionUsuario_CN.NombreUsuario = GuardarUsuario.nombreUsuario;

                    frmPaginaPrincipal crearEquipo = new frmPaginaPrincipal();
                    crearEquipo.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearCuenta CrearCuenta = new frmCrearCuenta();
            CrearCuenta.ShowDialog();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
