using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FCamara.Shared.Enum
{
    public enum TipoConta
    {
        [Description("Conta Corrente")]
        Corrente = 1,
        [Description("Conta Poupança")]
        Poupanca = 2
    }
}
