using FCamara.Shared.Base;
using FCamara.Shared.Enum;
using System;

namespace FCamara.Domain.Entities
{
    public class ContaCorrente : EntityBase
    {
        public int Banco { get; private set; }

        public int Agencia { get; private set; }

        public int Conta { get; private set; }

        public int Digito { get; private set; }

        public TipoConta Tipo { get; protected set; }

        public decimal Saldo { get; private set; }


        public ContaCorrente(int banco, int agencia, int conta, int digito, TipoConta tipo)
        {
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            Digito = digito;
            Tipo = tipo;
        }

        public void Debitar(decimal valor)
        {
            this.Saldo -= valor;
        }

        public void Creditar(decimal valor)
        {
            this.Saldo += valor;
        }
        public void SetarSaldoInicial(decimal valor)
        {
            this.Saldo = valor;
        }
        public void SetarId(Guid Id)
        {
            this.Id = Id;
        }
    }
}
