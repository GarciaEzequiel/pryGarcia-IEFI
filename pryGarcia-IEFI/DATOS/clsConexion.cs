﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGarcia_IEFI
{
    public class clsConexion
    {
        private readonly string cadena = "Server=localhost;Database=GestionRRHH;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }

        public static void EjecutarScriptMigracion()
        {
            string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"DATOS", "Scripts", "DBScript.sql");

            if (!File.Exists(scriptPath))
            {
                throw new FileNotFoundException("No se encontró el archivo DBScript.sql en la carpeta Scripts.");
            }

            string script = File.ReadAllText(scriptPath);

            using (SqlConnection conn = new SqlConnection("Server=localhost;Integrated Security=true;TrustServerCertificate=True;"))
            {
                conn.Open();
                foreach (string command in script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    using (SqlCommand cmd = new SqlCommand(command, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
