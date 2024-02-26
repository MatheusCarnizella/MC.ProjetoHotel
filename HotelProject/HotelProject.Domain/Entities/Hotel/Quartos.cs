using HotelProject.Domain.Entities.Common;

namespace HotelProject.Domain.Entities.Hotel
{
    public class Quartos : IRoom
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Andar { get; set; }
        public ICollection<Aluguel> Aluguel { get; set; }
        public bool Manutencao { get; set; }
        public bool Alugado { get; set; }
        public bool Disponivel { get 

            { if (Manutencao || Alugado) 
                {
                    return false;
                } 

              return true;
            } 
        }
    }
}
