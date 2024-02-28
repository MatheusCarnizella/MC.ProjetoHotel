namespace HotelProject.Domain.Repositories.Usuario
{
    public interface IUsuarioRepository
    {
        Task<Entities.Hotel.Usuario> Get(int id);
        Task<int> Criar(Entities.Hotel.Usuario usuario);

    }
}
