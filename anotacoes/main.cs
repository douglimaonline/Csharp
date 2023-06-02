using System;

class Program {
  public static void Main ()
  {
    // comentários usam duas barras e para incluir descrições são 3 barras
            /*Comentários com várias linhas deve começar com barra asterístico e finaliza com barra asterístico
            */

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
    
    Console.Write ("Qual é o seu nome: ");
    var nome = Console.ReadLine();
    
Console.Write ("Qual é sua idade: ");
    var idade = int.Parse(Console.ReadLine()); //Comando int.parse transforma a string em integer

    Console.WriteLine ($"{nome}   tem {idade}"); // O $ é tipo o f do fstring do python

Console.WriteLine("Digite um número");
string palavra = Console. ReadLine ();
int numero;
int. TryParse (palavra, out numero); //tryparse tenta converter o valor armazenado como string para integer (neste caso), se não conseguir ele retorna 0
Console.WriteLine("Resultado:{0}", numero);

    //IMC
    var peso = 75.2;
    var altura = 1.72;
    var imc = peso / Math.Pow (altura, 2);
    Console.Write ($"O imc é {imc}");

    int par = 56;
    int impar = 15;
    Console.WriteLine ($"{par}/2 tem resto {par % 2}");
    Console.Write ($"{impar}/2 tem resto {impar % 2}"); 

    // os símbolos de operador logico são iguais ao de python
    // and = && ; ou = || ; ou exclusivo = ^ (não tem no python)
    /* a exclamação (!) serve como operador que inverte o sinal da booleana
    isso é chamado de negação lógica e é só colocar na frente da variante bool*/

    // Operador Ternario - syntaxe semelhante a função "se" do excel
    Console.Write ("Qual sua nota? ");
    var nota = int.Parse (Console.ReadLine ());
    string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";

    Console.Write (resultado);
  }
}