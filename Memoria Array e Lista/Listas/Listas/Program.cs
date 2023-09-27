using System.Collections.Generic;

namespace Listas {
internal class Program {
        static void Main(string[] args) {

            List<string> MyList = new List<string>();

            MyList.Add("Juca");
            MyList.Add("Doug");
            MyList.Add("Romuro");
            MyList.Add("Gili");
            MyList.Insert(1, "Nina");


            foreach (var item in MyList) {
                Console.WriteLine(item);
            }

            List<string> NewList = (MyList.FindAll(x => x.Length > 4));
            Console.WriteLine();
            foreach (var item in NewList) { Console.WriteLine(item); }

            MyList.RemoveAll(x => x.Length > 4);
            Console.WriteLine();
            foreach (var item in MyList) { Console.WriteLine(item); }

        }    
   }
}