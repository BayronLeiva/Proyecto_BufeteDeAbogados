using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;

namespace Datos.Conexiones
{
    public class UsuariosConexion
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=bufeteabogados; Uid=root; Pwd= Bayron200028;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuarios Login(string codigo, string clave)
        {
            Usuarios usuario = null;

            try
            {
                string sql = "SELECT * FROM usuarios WHERE Codigo = @Codigo AND Clave = @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuarios();
                    usuario.Codigo = reader[0].ToString();
                    usuario.Clave = reader[1].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {
            }
            return usuario;
        }
    }
}
