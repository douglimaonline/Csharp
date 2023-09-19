using System.Globalization;

namespace ExerciciosDeFixacao {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("------------ Informe a altura de 3 pessoas abaixo e receba a média de altura ------------\n");
            double[] vect = new double[3];
            for (int i = 0; i < vect.Length; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double total = 0;
            for (int i = 0; i < vect.Length; i++) {
                total += vect[i];
            }
            double media = total / vect.Length;
            Console.WriteLine($"Altura média é {media.ToString("F2", CultureInfo.InvariantCulture)}\n");

            Console.WriteLine("------------ Informe a quantidade de produtos, o nome e o preço de cada um e receba a média de preço deles ------------\n");

            Console.Write("Quantidade de produtos: ");
            int qnt = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[qnt];

            for (int i = 0; i < qnt; i++) {
                Console.Write("Nome do produto: ");
                string NomeDoProduto = Console.ReadLine();
                Console.Write("Valor do produto: ");
                double ValorDoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto { Nome = NomeDoProduto, Valor = ValorDoProduto };
            }
            total = 0;
            for (int i = 0; i < qnt; i++) {
                total += produtos[i].Valor;
            }
            media = total / qnt;
            Console.WriteLine($"A média de preços é {media.ToString("F2", CultureInfo.InvariantCulture)}\n");

            Console.WriteLine("------------ Exercício de Fixação ------------\n");

            Console.Write("How many rooms will be rented? ");
            int TotalRooms = int.Parse(Console.ReadLine());

            Student[] StudentList = new Student[10];

            for (int i = 0; i < TotalRooms; i++) {
                Console.Write("\nStudent's Name: ");
                string StudentName = Console.ReadLine();
                Console.Write("Student's Email: ");
                string StudentEmail = Console.ReadLine();
                Console.Write("Choose a Number Room: ");
                int SelectedRoom = int.Parse(Console.ReadLine());

                StudentList[SelectedRoom] = new Student { Name = StudentName, Email = StudentEmail, RoomNumber = SelectedRoom };
            }
            Console.WriteLine("\nBusy Rooms:");
            for (int i = 0; i < 10; i++) {
                if (StudentList[i] != null) {
                    Console.WriteLine($"{StudentList[i].RoomNumber}: {StudentList[i].Name}, {StudentList[i].Email}");
                }
                
            }
        }
    }
}