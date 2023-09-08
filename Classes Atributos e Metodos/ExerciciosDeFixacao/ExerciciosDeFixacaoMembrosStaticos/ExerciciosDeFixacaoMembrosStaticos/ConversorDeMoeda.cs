using System;

namespace ExerciciosDeFixacaoMembrosStaticos {
    internal class ConversorDeMoeda {

        public static double Calculo(double cotacao, double dolares) {
            double resultadoBruto = (cotacao * dolares);
            double resultado = resultadoBruto + (resultadoBruto * 0.06);
            return resultado;
        }
    }
}
