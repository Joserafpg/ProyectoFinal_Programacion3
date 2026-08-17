namespace CapaEntidades
{
    // datos que comparten todas las personas del sistema (clientes, entrenadores)
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }
    }
}
