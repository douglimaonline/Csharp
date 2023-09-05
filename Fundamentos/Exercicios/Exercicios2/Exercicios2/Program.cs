using System;
using System.Threading.Channels;

// --------------------------- Exercícios 2 ---------------------------

Console.WriteLine("--------------------------- Exercício 03 ---------------------------");

Console.Write("Informe o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2) {
    if (num1 % num2 == 0) {
        Console.WriteLine("São Multiplos.");
    }
    else {
        Console.WriteLine("Não são Multiplos");
    }
}
else {
    if (num2 % num1 == 0) {
        Console.WriteLine("São Multiplos.");
    }
    else {
        Console.WriteLine("Não são Multiplos");
    }
}

Console.WriteLine("--------------------------- Exercício 08 ---------------------------");

while (true) {

    Console.Write("Informe seu salário: ");
    double salario = double.Parse(Console.ReadLine());

    if (salario <= 2000) {
        Console.WriteLine("Você está Isento do Imposto de Renda.");
    }
    else if (salario <= 3000) {
        Console.WriteLine($"Você de deve R${((salario - 2000) * 0.08).ToString("F2")} de Imposto de Renda.");
    }
    else if (salario <= 4500) {
        Console.WriteLine($"Você de deve R${((salario - 2000) * 0.18).ToString("F2")} de Imposto de Renda.");
    }
    else {
        Console.WriteLine($"Você de deve R${((salario - 2000) * 0.28).ToString("F2")} de Imposto de Renda.");
    }
}