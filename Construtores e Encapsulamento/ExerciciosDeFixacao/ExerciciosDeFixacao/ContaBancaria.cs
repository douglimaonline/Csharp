using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeFixacao {
    internal class ContaBancaria {
        /* cta bancária
             * numero da conta
             * nome do titular
             * deposito inicial
             */

        // Atributos
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        // Construtores
        public ContaBancaria(int id, string nome) {
            Id = id;
            Name= nome;
        }
        public ContaBancaria(int id, string nome, double saldo) {
            Id = id;
            Name = nome;
            Balance = saldo;
        }

        // Métodos
        public void Deposito(double valor) {
            Balance += valor;
        }
        public void Saque(double valor) {
            Balance -= valor;
            Balance -= 5.00; // Taxa de $5
        }

        public override string ToString() {
            return $"Conta {Id}, Titular: {Name}, Saldo: ${Balance.ToString("F2")}\n";
        }
    }
}
