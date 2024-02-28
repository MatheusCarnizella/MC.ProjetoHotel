using HotelProject.Api.Endpoints;

namespace HotelProject.Api
{
    public static class Mapping
    {
        internal static void MappingEndpoits(this WebApplication app)
        {
            Usuario.Map(app);
        }
    }
}
