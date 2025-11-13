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
    public partial class frmCrearCuenta : Form
    {
        private clsCrearCuenta_CN ObjCrearCuenta = new clsCrearCuenta_CN();

        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        public bool mtdVerficarCamposVacios()
        {
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                MessageBox.Show("No dejar dato nombre vacio");
                return true;
            }

            return false;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (mtdVerficarCamposVacios())
            {
                return;
            }

            //INFORMACION DE LA CUENTA
            string NombreUsuario = txtNomUsuario.Text;
            string Clave = txtContraseña.Text;
            

            //INFORMACION PERSONAL
            string Nombres = txtNombres.Text.ToUpper();
            string ApellidoPaterno = txtPaterno.Text.ToUpper();
            string ApellidoMaterno = txtMaterno.Text.ToUpper();
            string Documento = txtDocumento.Text;
            string Genero = cmbGenero.Text;

            int IDTipoDocumento = Convert.ToInt32(cmbTipoDocumento.SelectedValue);

            DateTime FechaNacimiento = dtpNacimiento.Value;
            string Telefono = txttelefono.Text;
            string Correo = txtCorreo.Text;

            try
            {
                //NO DEBE PERMITIR QUE OTRO USUARIO SE CREE UNA CUENTA CON UN CORREO YA REGISTRADO
                /*
                 * DAR A CONOCER QUE EL CORREO YA ESTA EN USO
                 */

                ObjCrearCuenta.mtdCrearCuentaCN(Nombres,
                                                ApellidoPaterno,
                                                ApellidoMaterno, 
                                                IDTipoDocumento, 
                                                Documento, 
                                                FechaNacimiento, 
                                                Telefono, 
                                                Correo, 
                                                Genero,
                                                NombreUsuario,
                                                Clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {
            //https://es.stackoverflow.com/questions/339323/cargar-datos-en-textbox-usando-combobox-conectado-con-sql
            cmbTipoDocumento.DataSource = ObjCrearCuenta.mtdListarTipoDocumentoActivosCD();
            cmbTipoDocumento.DisplayMember = "TipoDocumento";
            cmbTipoDocumento.ValueMember = "IDTipoDocumento";

            cmbTipoDocumento.SelectedIndex = -1;
        }
    }
}
