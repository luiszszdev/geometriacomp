using capaDatos.Modelos;
namespace capaDatos.Modelos;

public class Grupos
{   
    public int IdGrupo { get; set; }
    public string Nombre { get; set; }
    public int Size { get; set; }
    public Grupos(int _IdGrupo, string _nombre, int _size)
    {
        IdGrupo = _IdGrupo;
        Nombre = _nombre;
        Size = _size;
    }

}
