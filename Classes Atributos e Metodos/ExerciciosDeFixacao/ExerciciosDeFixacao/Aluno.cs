

namespace ExerciciosDeFixacao {
    internal class Aluno {
        public string Nome = null;
        public double nota1 = 0;
        public double nota2 = 0;
        public double nota3 = 0;

        public void avaliacao() {
            double NotaFinal = (nota1 + nota2 + nota3);
            if (NotaFinal >= 60.00) {
                Console.WriteLine($"NOTA FINAL = {NotaFinal}");
            }
            else if (NotaFinal < 60) {
                Console.WriteLine($"NOTA FINAL = {NotaFinal}");
                Console.WriteLine($"REPROVADO");
                Console.WriteLine($"FALTARAM {(60.00 - NotaFinal).ToString("F2")} PONTOS");
            }
        }
    }
}
