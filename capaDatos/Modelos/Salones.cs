using capaDatos.Modelos;
namespace capaDatos.Modelos;

public class Salones
{
    public int IdSalon { get; set; }
    public string Nombre { get; set; }
    public  int Capacidad { get; set; }
    public string TipoSalon { get; set; }
    public bool Ocupado { get; set; }

    public Salones(int _IdSalon, string _nombre, int _Capacidad, string _tipoSalon, bool _ocupado)
    {
        IdSalon = _IdSalon;
        Nombre = _nombre;
        Capacidad = _Capacidad;
        TipoSalon = _tipoSalon;
        Ocupado = _ocupado;
    }
}
