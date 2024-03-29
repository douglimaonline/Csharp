﻿// Alterações que achei interessante após as correções:
using System;
using System.Globalization;


namespace ExerciciosDeFixacao {
    internal class ContaBancaria {

        // Atributos
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        // Construtores
        public ContaBancaria(int id, string nome) {
            Id = id;
            Name = nome;
        }

        public ContaBancaria(int id, string name, double depositoInicial) : this(id, name) {
            Deposito(depositoInicial);
        }//Ponto importante! Este construtor utiliza o metodo de deposito, pois precisa respeitar as regras de negocio para esta operação


        // Métodos
        public void Deposito(double valor) {
            Balance += valor;
        }
        public void Saque(double valor) {
            Balance -= valor + 5;
        }

        public override string ToString() {
            return $"Conta {Id}, Titular: {Name}, Saldo: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}
