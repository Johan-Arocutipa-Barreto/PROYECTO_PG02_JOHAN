using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsGestionEquipos_CN
    {
        private clsGestionEquipos_CD ObjgestionEquipos = new clsGestionEquipos_CD();

        public void mtdCrearEquipoCN(int IDCreador, string NombreEquipo, string Descripcion)
        {
            ObjgestionEquipos.mtdCrearEquipoCD(IDCreador, NombreEquipo, Descripcion);
        }

        public DataTable mtdListarEquiposPorUsuarioCD(int IDCreador)
        {
            DataTable tbEquipos = new DataTable();
            tbEquipos = ObjgestionEquipos.mtdListarEquiposPorUsuarioCD(IDCreador);
            return tbEquipos;
        }
    }
}
