using ExerciciosDeFixacao;

namespace Exercicios {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("---------- Exercício 1 ----------");

            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("Largura: ");
            retangulo.largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            retangulo.altura = double.Parse(Console.ReadLine());

            retangulo.resultados();
            Console.WriteLine("");

            Console.WriteLine("---------- Exercício 2 ----------");

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Dados do Funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine($"Imposto: {funcionario.Imposto}");
            Console.WriteLine(funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine(funcionario);

            Console.WriteLine("---------- Exercício 3 ----------");

            Aluno aluno = new Aluno();

            Console.WriteLine("Dados do Aluno:");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota 1: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            aluno.nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            aluno.nota3 = double.Parse(Console.ReadLine());

            aluno.avaliacao();
        }   
    }
}