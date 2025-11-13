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
    public partial class frmPaginaPrincipal : Form
    {
        private clsGestionEquipos_CN ObjGestionEquipos = new clsGestionEquipos_CN();

        int IDCreador = clsSesionUsuario_CN.idUsuario;

        public frmPaginaPrincipal()
        {
            InitializeComponent();
        }

        private void frmPaginaPrincipal_Load(object sender, EventArgs e)
        {
            dgvEquiposUsuario.DataSource = ObjGestionEquipos.mtdListarEquiposPorUsuarioCD(IDCreador);
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            frmCrearEquipo equipo = new frmCrearEquipo();
            equipo.ShowDialog();
        }

        private void btnInvitar_Click(object sender, EventArgs e)
        {
            frmInvitarUsuarioEquipo frmInvitar = new frmInvitarUsuarioEquipo();
            frmInvitar.ShowDialog();
            
            MessageBox.Show("El id es: " + txtIDEquipo.Text);
        }

        private void dgvEquiposUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvEquiposUsuario.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                   txtIDEquipo.Text = row.Cells["IDEquipo"].Value.ToString();
                }
            }
        }
    }
}
