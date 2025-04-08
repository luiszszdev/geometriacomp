using CapaDatos;
using capaDatos.Modelos;
using capaDatos.Repositorio.Interfaces;
using System.Data.SqlTypes;

namespace capaDatos.Repositorio.Implementacion
{
    public class GrupoRepositorio : IGrupoRepositorio
    {
        //metodos de la interfaz
        private readonly Conexion conexion;
        public GrupoRepositorio(Conexion _conexion)
        {
            conexion = _conexion;
        }

        public async Task<List<Grupos>> AgregarGrupo()
        {
            List<Grupos> ListGrupos = new List<Grupos>();
            ListGrupos.AddRange(
                new[] {
                    new Grupos (1, "GrupoA", 20 ) 
                });
            return ListGrupos;
        }
    }
}
