using System;
using System.Globalization;

namespace Estoque
{
    internal class Produto
    {
        private string _nome; // nao usaremos o auto property, pois ele tem uma lógica particular.
        // Auto Property - 3º maneira de encapsulamento (a melhor)
        public double Preco { get; private set; } // atalho: type: prop + tab + tab
        public int Quantidade { get; private set; }

        
        /* maneira antiga
        private double _preco;
        private int _quantidade;
        */

        //  * Proposta de melhoria (Produtos) -> Criar um construtor opcional, o qual recebe apenas nome e preço do produto.
        //  A qtde em estoque desse produto deve ser inicializada por padrão como zero.
        public Produto(string nome, double preco)
        { // construtor tem o mesmo nome da classe
            _nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        { // construtor tem o mesmo nome da classe
            Quantidade = quantidade;
        }

        public Produto() { } // Construtor sem parametros (sem valores iniciais)

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /* Property - 2º maneira de encapsulamento
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade {
            get { return _quantidade; }
        }
        */

        /* Encapsulamento - 1º maneira
        public string GetNome() { return _nome; }
        public void SetNome(string nome) { _nome = nome;}
        
        public double GetPreco() { return _preco; }
        public void SetPreco(double preco) { _preco = preco; }
        public int GetQuantidade() {  return _quantidade; }
        public void SetQuantidade(int quantidade) {  _quantidade = quantidade;}
        */

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
        }
        public override string ToString()
        {
            return _nome + ", $ " 
                        + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", " + Quantidade + " unidades, Total: $ " 
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
