using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FCamara.Shared.Enum
{
    public enum Banco
    {
        [Description("Santander")]
        Santander = 33,
        [Description("Itau")]
        Itau = 341,
        [Description("Banco do Brasil")]
        BancoBrasil = 1,
        [Description("Caixa Econômica Federal")]
        Caixa = 104,
        [Description("Bradesco")]
        Bradesco = 237
    }
}
