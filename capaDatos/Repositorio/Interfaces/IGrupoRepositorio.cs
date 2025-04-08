using capaDatos.Modelos;

namespace capaDatos.Repositorio.Interfaces
{
    public interface IGrupoRepositorio
    {
        //declarar los metodos de la interfaz para la entidad grupo
        public Task<List<Grupos>> AgregarGrupo();
    }
}
