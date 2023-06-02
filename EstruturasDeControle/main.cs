using System;

class Program {
  public static void Main () {
    
    Console.Write ("Digite a nota do aluno: ");
    int.TryParse(Console.ReadLine (), out int nota);

    if (nota >= 7) {
      Console.WriteLine ("Aprovado");}
    else if (nota >= 3){
      Console.WriteLine ("Recuperação");}
      else {
      Console.WriteLine ("Reprovado");
      }
      switch (nota) { // esse switch é novidade, Interessante!  
      case 0:
      case 1:
      case 2:
      case 3:
        Console.WriteLine ("Vai pra casa");
        break;
      case 4:
      case 5:
      case 6:
        Console.WriteLine ("Te vejo segunda");
        break;
      case 7:
      case 8:
      case 9:
        Console.WriteLine ("Parabéns!");
        break;
      case 10:
        Console.WriteLine ("Einsten!");
        break;
      default:
        Console.WriteLine ("Nota Inválida");
        break;
      }
    

    
  }
}