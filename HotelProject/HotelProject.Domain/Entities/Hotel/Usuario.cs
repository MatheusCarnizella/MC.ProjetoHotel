using HotelProject.Domain.Entities.Common;

namespace HotelProject.Domain.Entities.Hotel
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
