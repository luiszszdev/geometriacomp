using capaDatos.Modelos;

namespace capaDatos.Modelos
{
    public class Profesores
    {

        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public List<Grupos> profeGrupos { get; set; }
        public List<Asignatura> profeAsignaturas { get; set; }
        
        public bool Ocupado { get; set; }
        public Profesores(int _IdProfesor, string _nombre, List<Grupos> _profesgrupos, 
            List<Asignatura> _profeAsignaturas, bool _ocupado)
        {
            IdProfesor = _IdProfesor;
            Nombre = _nombre;
            profeGrupos = _profesgrupos;
            profeAsignaturas = _profeAsignaturas;
            Ocupado = _ocupado;

        }
    }
}
