using FCamara.Shared.Base;
using FCamara.Shared.Enum;
using System;

namespace FCamara.Domain.Entities
{
    public class Lancamentos : EntityBase
    {
        public ContaCorrente ContaOrigem { get; private set; }

        public ContaCorrente ContaDestino { get; private set; }

        public Operacao Tipo { get; private set; }

        public DateTime DataOperacao { get; private set; }

        public Lancamentos(ContaCorrente contaOrigem, ContaCorrente contaDestino, Operacao tipo, DateTime dataOperacao)
        {
            this.ContaOrigem = ContaOrigem;
            this.ContaDestino = ContaDestino;
            this.Tipo = tipo;
            this.DataOperacao = dataOperacao;
        }

        public void Debitar(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor)
        {
            this.ContaOrigem.Debitar(valor);
            this.ContaDestino.Creditar(valor);
        }
        public void Creditar(ContaCorrente contaOrigem, ContaCorrente contaDestino, decimal valor)
        {
            this.ContaOrigem.Creditar(valor);
            this.ContaDestino.Debitar(valor);
        }
    }
}
