using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOAgenciaBancaria.Dominio
{
    public static class Validacoes
    {
        public static string ValidaStringVazia(this string dado)
        {
            return string.IsNullOrWhiteSpace(dado) ?
                throw new Exception("Propriedade deve estar preenchida.") :
                dado;
        }
    }
}
