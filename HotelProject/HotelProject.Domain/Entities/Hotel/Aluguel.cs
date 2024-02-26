using HotelProject.Domain.Entities.Common;
using HotelProject.Domain.Entities.Enums;

namespace HotelProject.Domain.Entities.Hotel
{
    public class Aluguel : IAluguel
    {
        public int Id { get; set; }
        public string AlugadoPor {  get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim {  get; set; }
        public Status Status { get; set; }
    }
}
