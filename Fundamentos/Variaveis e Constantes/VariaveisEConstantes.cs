using System;

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
        }
    }
}