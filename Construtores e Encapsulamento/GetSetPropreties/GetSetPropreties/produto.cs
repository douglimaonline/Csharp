using System;
using System.Collections.Generic;
using System.Globalization;


namespace GetSetPropreties {
    class Produto {

        /* Ordem ideal para implementação dos atributos/metodos:
         * Atributos privados
         * propriedades autoimplementadas
         * construtores
         * propriedades customizadas
         * outros metodos de classe
        */
        private string _nome; // Atributos privados
        private double _preco;
        public int Quantidade {  get; private set; } //Propriedades autoimplementadas (atalho: "prop" tab tab)

        public Produto(string nome, double preco, int quantidade) { // Constutor
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) { // Sobrecarga (Quando há mais de um Construtor)
            _nome = nome;
            _preco = preco;
        }

        public string Nome { //Propreties cutomizadas: Vc consegue criar condições mas ainda usar no programa central a syntaxe de atributos
            get { return _nome; }
            set { 
                if (value != null && value.Length > 1) { 
                _nome = value;
                }
            }
        }

        public double Preco { // set { _preco = value; } Não colocar set se vc não quer que alterem o preço, o usuário não terá acesso a alteração deste informação por segurança
            get { return _preco; } 
        }
        // Métodos:
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
