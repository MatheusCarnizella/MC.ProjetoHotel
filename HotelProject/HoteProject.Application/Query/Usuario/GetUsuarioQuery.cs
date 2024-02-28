using HotelProject.Application.Interfaces.Usuario;
using HotelProject.Application.Requests.Usuario;
using HotelProject.Application.Responses.Usuario;
using HotelProject.Domain.Repositories.Usuario;
using User = HotelProject.Domain.Entities.Hotel.Usuario;

namespace HotelProject.Application.Query.Usuario
{
    public class GetUsuarioQuery : IUsuarioHandler
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public GetUsuarioQuery(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioResponse> CriarUsuario(UsuarioRequest request)
        {
            var usuario = new User
            {
                Nome = request.Nome
            };

            var usuarioId = await _usuarioRepository.Criar(usuario);

            var response = new UsuarioResponse()
            {
                Id = usuarioId,
                Nome = usuario.Nome
            };

            return response;
        }
    }
}
