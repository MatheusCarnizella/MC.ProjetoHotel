using HotelProject.Application.Requests.Usuario;
using HotelProject.Application.Responses.Usuario;

namespace HotelProject.Application.Interfaces.Usuario
{
    public interface IUsuarioHandler
    {
        Task<UsuarioResponse> CriarUsuario(UsuarioRequest request);
    }
}
