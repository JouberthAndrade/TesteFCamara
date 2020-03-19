using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FCamara.Shared.Enum
{
    public enum Operacao
    {
        [Description("Crédito")]
        Credito = 1,
        [Description("Débito")]
        Debito = 2
    }
}
