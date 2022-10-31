using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook";
            string marca = "Dell";
            double valor = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + valor + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, valor);
            Console.WriteLine($"O {nome} da marca {marca} custa {valor}.");
        }
    }
}
