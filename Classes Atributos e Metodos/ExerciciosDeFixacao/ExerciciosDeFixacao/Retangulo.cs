using System;

namespace ExerciciosDeFixacao {
    internal class Retangulo {
        public double largura = 0;
        public double altura = 0;

        public double Area() {
            return largura * altura;
        }

        public double Perimetro() {
            return (largura + altura) * 2;
        }
        public double Diagonal() { 
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
        public void resultados () {
            Console.WriteLine($"AREA = {Area().ToString("F2")}");
            Console.WriteLine($"PERÍMETRO = {Perimetro().ToString("F2")}");
            Console.WriteLine($"DIAGONAL = {Diagonal().ToString("F2")}");
        }
    }
}
