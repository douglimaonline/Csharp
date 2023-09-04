using System;
using System.Globalization;

namespace csharp.Fundamentos
{
    class VariaveisEConstatnes
    {
        static void Main() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Área é "+ area);

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);


            /*
            - Variáveis 'double' - o dobro do float
            - Constantes 'const'
            - Boleanas 'bool'
            - 2 bytes'short'
            - 4 bytes'int'
            - 8 bits 'byte'
            - 8 byts'long' - o dobro do int
            - aceita sinal 'sbyte'
            - int sem sinal "'unint'
            - float number 'float number' - se não botar o f no final do numero ele fica como double
            - uma letra 'char' - aspas simples
            - varias letras - string
            */

            Console.WriteLine("------- Variáveis --------");

            string name = "Maria";
            int age = 47;
            double balance = 2.4657;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(balance);
            Console.WriteLine(balance.ToString("F3", CultureInfo.InvariantCulture)); // Altera o tipo de divisão de centavos e milhar

            Console.WriteLine("------- Interpolação --------");
            Console.WriteLine($"{name} têm {age} anos e {balance.ToString("F3", CultureInfo.InvariantCulture)} reais na conta.");

            Console.WriteLine("------- Operadores de Atribuição --------");

            // Os operadores += funciona com string, ele concatena as infos.
            string a = "ABC";
            a += "DEF";
            Console.WriteLine(a);

            // Também temos os operadores ++ e -- que não existe em python mas funciona da mesa forma 
            // do javascript.

            // Observar o comportamento abaixo
            int x = 5;
            int y = x++;
            Console.WriteLine(x); // Considerou o x++ e printou 6.
            Console.WriteLine(y); // Primeiro considerou o valor de x (=5) e depois o ++.

            // Porém se eu incluir o == na frente da variável ele vai somar antes considerar o valor da var.
            int z = 5;
            int k = ++z;
            Console.WriteLine(z);
            Console.WriteLine(k);


            Console.WriteLine("------- Casting --------");

            int casta = 5;
            int castb = 2;
            double result = (double)casta / castb; // Se não tiver o casting (double entre parenteses na frente) ele trás 2 e não 2,5
            Console.WriteLine(result);

        }
    }
}