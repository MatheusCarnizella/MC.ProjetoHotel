using HotelProject.Domain.Entities.Common;
using HotelProject.Domain.Entities.Enums;

namespace HotelProject.Domain.Entities.Hotel
{
    public class Aluguel : IAluguel
    {
        public Aluguel() => Status = Status.Aberto;

        public int Id { get; set; }
        public string AlugadoPor {  get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim {  get; set; }
        private Status Status { get; set; }
        public Status StatusAtual { get
            {
                return Status;
            } 
        }

        public void AcaoUsuario(AcoesUsuario acao)
        {
            Status = (Status, acao) switch
            {
                (Status.Aberto, AcoesUsuario.Pago) => Status.Pago,
                (Status.Aberto, AcoesUsuario.Cancelado) => Status.Cancelado,
                (Status.Pago, AcoesUsuario.Final) => Status.Finalizado,
                (Status.Pago, AcoesUsuario.Reenbolso) => Status.Reembolsado,
                (Status.Cancelado, AcoesUsuario.Reaberto) => Status.Aberto,
                _ => Status
            };
        }
    }
}
