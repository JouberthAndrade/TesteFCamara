using FCamara.Shared.Enum;
using System;

namespace FCamara.Shared.Dto
{
    public class LancamentoDto
    {

        public ContaDto ContaOrigem { get;  set; }

        public ContaDto ContaDestino { get;  set; }

        public Operacao Tipo { get;  set; }

        public DateTime DataOperacao { get;  set; }
    }
}
