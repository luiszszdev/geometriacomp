using capaDatos.Modelos;

namespace capaDatos.Modelos
{
    public class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string Materia { set; get; }

        public int Bloques;
        public int Prioridad { get; set; }
        public List<Grupos> asignaturaGrupos { get; set; }
        public List<Salones> asignaturaSalones { get; set; }

        public Asignatura(int _IdAsignatura, string _materia, int _bloques, int _prioridad, 
            List<Grupos> _asignaturaGrupos, List<Salones> _asignaturaSalones)
        {
            IdAsignatura = _IdAsignatura;
            Materia = _materia;
            Bloques = _bloques;
            Prioridad = _prioridad;
            asignaturaGrupos = _asignaturaGrupos;
            asignaturaSalones = _asignaturaSalones;

        }


    }
}