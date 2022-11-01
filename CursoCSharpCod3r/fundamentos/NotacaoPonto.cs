using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() {
            string saudacao = "olá mundo".ToUpper();
            Console.WriteLine(saudacao);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
