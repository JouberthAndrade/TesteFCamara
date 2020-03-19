using FCamara.Shared.Dto;

namespace FCamara.Application.Command
{
    public class LancamentoCommand
    {
        public ContaDto contaOrigem { get; set; }
        public ContaDto contaDestino { get; set; }
        public decimal valor { get; set; }
    }
}
