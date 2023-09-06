

namespace ExerciciosDeFixacao {
    internal class Funcionario {
        public string Nome = null;
        public double SalarioBruto = 0.00;
        public double Imposto = 1000.00;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario (double porcentagem) {
            SalarioBruto += (SalarioBruto * (porcentagem / 100));
        }
        public override string ToString () {
            return $"Dados atualizados: {Nome}, ${SalarioBruto-Imposto}\n";
        }
    }
}
