using System;
using System.Collections.Generic;
using System.Globalization;


namespace GetSetPropreties {
    class Produto {
        private string _nome;
        private double _preco;
        public int Quantidade {  get; private set; } //Auto propreties

        public Produto(string nome, double preco, int quantidade) { // Constutor
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) { // Sobrecarga (Quando há mais de um Construtor)
            _nome = nome;
            _preco = preco;
        }

        public string Nome { //propreties: Vc consegue criar condições mas ainda usar no programa central a syntaxe de atributos
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) { 
                _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; } 
            // set { _preco = value; } Não colocar set se vc não quer que alterem o preço, o usuário não terá acesso a alteração deste informação por segurança
        }

        public double ValorTotalEmEstoque() {
            return _preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
