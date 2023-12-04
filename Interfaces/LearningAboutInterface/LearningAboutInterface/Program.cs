namespace LearningAboutInterface;



internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Operation: ");
        string Oper = Console.ReadLine();

        Console.Write("n1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("n2: ");
        int n2 = int.Parse(Console.ReadLine());

        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.UseCalculator(Oper, n1, n2));
        
    } 
}