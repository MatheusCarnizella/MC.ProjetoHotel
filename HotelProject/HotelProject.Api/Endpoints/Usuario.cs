using HotelProject.Application.Interfaces.Usuario;
using HotelProject.Application.Query.Usuario;
using HotelProject.Application.Requests.Usuario;
using HotelProject.Application.Responses.Usuario;
using HotelProject.Domain.Repositories.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Api.Endpoints
{
    public partial class Usuario
    {
        public static void Map(WebApplication app)
        {
            app.MapPost("/hotel/usuarios", async ([FromServices]GetUsuarioQuery handler, [FromBody] UsuarioRequest request) =>
            {
                try
                {
                    var response = await handler.CriarUsuario(request);
                    return Results.Ok(response);
                }

                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            })
              .Produces<UsuarioResponse>(200)
              .Produces(400);

            app.MapGet("/hotel/usuarios/{id}", async (int id, [FromServices] IUsuarioRepository usuarioRepository) =>
            {
                try
                {
                    var usuario = await usuarioRepository.Get(id);

                    if (usuario == null)
                    {
                        return Results.NotFound("Usuário não encontrado");
                    }

                    var response = new UsuarioResponse()
                    {
                        Id = usuario.Id,
                        Nome = usuario.Nome
                    };

                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
            })
              .Produces<UsuarioResponse>(200)
              .Produces(400)
              .Produces(500);
        }
    }
}

