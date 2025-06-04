using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGarcia_IEFI.DATOS
{
    public class clsUsuarioDatos
    {
        private readonly clsConexion conexion = new clsConexion();
        public clsUsuario ValidarLogin(string nombreUsuario, string contraseña)
        {
            clsUsuario usuario = null;

            string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @nombreUsuario AND Contraseña = @contraseña AND Activo = 1";

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new clsUsuario
                            {
                                IdUsuario = (int)reader["IdUsuario"],
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Dni = reader["Dni"].ToString(),
                                Contraseña = reader["Contraseña"].ToString(),
                                Area = reader["Area"].ToString(),
                                Activo = (bool)reader["Activo"],
                                NombreUsuario = reader["NombreUsuario"].ToString()
                            };
                        }
                    }
                }
            }
            return usuario;
        }


    }
}
