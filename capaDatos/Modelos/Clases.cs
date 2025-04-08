using capaDatos.Modelos;

namespace capaDatos.Modelos
{
    public class Clases
    {
        public int IdClase { get; set; }
        public Asignatura materia { get; set;}
        public Profesores profesor { get; set; }
        public Grupos grupo { set; get; }
        public Salones salon { get; set; }
        public string hora { get; set; }
        public Clases(int _IdClase, Asignatura _materia, Profesores _profesor, Grupos _grupo, Salones _salon, string _hora)
        {
            IdClase = _IdClase;
            materia = _materia;
            grupo = _grupo;
            profesor = _profesor;
            salon = _salon;
            hora = _hora; 
        }
    }
}
