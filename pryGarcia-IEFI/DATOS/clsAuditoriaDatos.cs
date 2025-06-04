using pryGarcia_IEFI.MODELOS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGarcia_IEFI.DATOS
{
    public class clsAuditoriaDatos
    {
        string error;
        private readonly clsConexion conexion = new clsConexion();
        public int RegistrarAuditoriaYDevolverId(clsAuditoria auditoria)
        {
            int idGenerado = -1;
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Auditorias (IdUsuario, Fecha, TiempoUso) " +
                               "OUTPUT INSERTED.IdAuditoria " +
                               "VALUES (@idUsuario, @fecha, @tiempo)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", auditoria.IdUsuario);
                    cmd.Parameters.AddWithValue("@fecha", auditoria.Fecha);
                    cmd.Parameters.AddWithValue("@tiempo", auditoria.TiempoUso);
                    idGenerado = (int)cmd.ExecuteScalar();
                }
            }
            return idGenerado;
        }

        public void ActualizarTiempoUso(int idAuditoria, int segundos)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Auditorias SET TiempoUso = @tiempo WHERE IdAuditoria = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tiempo", segundos);
                    cmd.Parameters.AddWithValue("@id", idAuditoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<clsAuditoria> ObtenerAuditoriasFiltradas(string usuario, DateTime? desde, DateTime? hasta)
        {
            List<clsAuditoria> lista = new List<clsAuditoria>();

            try
            {
                string consulta = @"
                SELECT A.IdAuditoria, U.NombreUsuario, A.Fecha, A.TiempoUso
                FROM Auditorias A
                INNER JOIN Usuarios U ON A.IdUsuario = U.IdUsuario
                WHERE 1 = 1";

                if (!string.IsNullOrWhiteSpace(usuario))
                {
                    consulta += " AND U.NombreUsuario LIKE @usuario";
                }

                if (desde.HasValue)
                {
                    consulta += " AND A.Fecha >= @desde";
                }

                if (hasta.HasValue)
                {
                    consulta += " AND A.Fecha <= @hasta";
                }

                using (SqlConnection conn = conexion.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    if (!string.IsNullOrWhiteSpace(usuario))
                        cmd.Parameters.AddWithValue("@usuario", $"%{usuario}%");

                    if (desde.HasValue)
                        cmd.Parameters.AddWithValue("@desde", desde.Value);

                    if (hasta.HasValue)
                        cmd.Parameters.AddWithValue("@hasta", hasta.Value);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        clsAuditoria a = new clsAuditoria
                        {
                            IdAuditoria = Convert.ToInt32(reader["IdAuditoria"]),
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            TiempoUso = Convert.ToInt32(reader["TiempoUso"])
                        };
                        lista.Add(a);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return lista;
        }

        public string ObtenerError() 
        {
            return error;
        }
    }
}   


