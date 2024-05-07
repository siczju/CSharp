using System;
using System.Globalization;

namespace Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public  int Quantidade;

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
            return Nome + ", $ " 
                        + Preco.ToString("F2", CultureInfo.InvariantCulture)
                        + ", " + Quantidade + " unidades, Total: $ " 
                        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
