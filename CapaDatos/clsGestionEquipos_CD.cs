using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsGestionEquipos_CD
    {
        //METODO PARA QUE EL USUARIO CREE UN ESPACIO DE EQUIPO
        public void mtdCrearEquipoCD(int IDCreador, string NombreEquipo, string Descripcion)
        {
            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                //INSERTAR DATOS PARA CREAR EL EQUIPO
                string query_I_Equipo = @"INSERT INTO tbEquipo (IDCreador, NombreEquipo, Descripcion)
                                        VALUES (@IDCreador, @NombreEquipo, @Descripcion);";

                using (SqlCommand cmd_I_Equipo = new SqlCommand(query_I_Equipo, connection))
                {
                    cmd_I_Equipo.Parameters.AddWithValue("@IDCreador", IDCreador);
                    cmd_I_Equipo.Parameters.AddWithValue("@NombreEquipo", NombreEquipo);
                    cmd_I_Equipo.Parameters.AddWithValue("@Descripcion", Descripcion);

                    cmd_I_Equipo.ExecuteNonQuery();
                }
            }
        }

        //METODO PARA LISTAR LOS EQUIPOS CREADOS POR EL USUARIO
        public DataTable mtdListarEquiposPorUsuarioCD(int IDCreador)
        {
            DataTable tbEquipos = new DataTable();

            using (SqlConnection connection = clsConexion_CD.mtdObtenerConexion())
            {
                connection.Open();

                //VER ID DE EQUIPO POR MIENTRAS

                string queryListar = @"SELECT IDEquipo, NombreEquipo, Descripcion, FechaRegistro 
                             FROM tbEquipo
                             WHERE IDCreador = @IDCreador
                             ORDER BY FechaRegistro DESC;";

                using (SqlCommand cmdListar = new SqlCommand(queryListar, connection))
                {
                    cmdListar.Parameters.AddWithValue("@IDCreador", IDCreador);

                    using (SqlDataReader reader = cmdListar.ExecuteReader())
                    {
                        tbEquipos.Load(reader);
                    }
                }
            }

            return tbEquipos;
        }
    }
}
