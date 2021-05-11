using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTesteDebug
{
    public static class FormatarNumeros
    {
        public static string FormatarCpf(long cpf)
        {
            var result = String.Format("{0:00000000000}", cpf);
            return result;
        }
    }
}
