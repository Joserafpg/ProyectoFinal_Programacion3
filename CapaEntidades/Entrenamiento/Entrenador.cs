namespace CapaEntidades
{
    public class Entrenador : Persona
    {
        public int IdEntrenador { get; set; }
        public string Especialidad { get; set; }
        public int IdHorario { get; set; }
        public string Horario { get; set; }
        public bool Estado { get; set; }
    }
}
