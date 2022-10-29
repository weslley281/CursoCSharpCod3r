using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpCod3r.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            bool estaChovendo = true;
            Console.WriteLine("Está chuvendo " + (estaChovendo ? "sim" : "não"));

            byte idade = 45;
            Console.WriteLine("Idade " + idade);


            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor de Int: " + menorValorInt);
        }
    }
}
