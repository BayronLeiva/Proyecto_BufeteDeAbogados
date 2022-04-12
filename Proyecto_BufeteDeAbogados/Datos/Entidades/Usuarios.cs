namespace Datos.Entidades
{
    public class Usuarios
    {
        public string Codigo { get; set; }

        public string Clave { get; set; }

        public Usuarios()
        {
        }

        public Usuarios(string codigo, string clave)
        {
            Codigo = codigo;
            Clave = clave;
        }
    }
}


