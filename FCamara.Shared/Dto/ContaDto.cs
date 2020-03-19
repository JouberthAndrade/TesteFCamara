using FCamara.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FCamara.Shared.Dto
{
    public class ContaDto
    {
        public int Banco { get;  set; }

        public int Agencia { get;  set; }

        public int Conta { get;  set; }

        public int Digito { get;  set; }

        public TipoConta Tipo { get;  set; }

        public decimal Saldo { get;  set; }
    }
}
