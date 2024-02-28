using HotelProject.Domain.Repositories.Usuario;
using HotelProject.Infra.Context;

namespace HotelProject.Infra.Repository.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private Context.Context _dbContext;
        public UsuarioRepository(Context.Context context) 
        {
            _dbContext = context;
        }

        public async Task<int> Criar(Domain.Entities.Hotel.Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            await _dbContext.SaveChangesAsync();
            return usuario.Id;
        }

        public async Task<Domain.Entities.Hotel.Usuario> Get(int id)
        {
            var usuario = await _dbContext.Usuarios.FindAsync(id);
            return usuario;
        }
    }
}
