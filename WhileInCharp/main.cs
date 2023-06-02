using System;

class Program {
  public static void Main () {
    Random random = new Random();
    int secretnum = random.Next(1, 11);

    var gameover = false;
       
      while (!gameover) {
      Console.Write ("Dê um palpite: ");
      int.TryParse(Console.ReadLine (), out int guess);

      if (secretnum > guess) {
        Console.WriteLine ("O número é maior");
      }
      else if (secretnum < guess) {
        Console.WriteLine ("O número é menor");
      }
      else if (secretnum == guess){
        Console.WriteLine ("Certou misera");
        gameover = true;
      }
      else {
        Console.WriteLine ("Palpite inválido");
        gameover = true;
      }
    }
  }
}