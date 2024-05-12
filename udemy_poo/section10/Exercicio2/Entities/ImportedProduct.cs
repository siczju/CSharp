using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Entities
{
    internal class ImportedProduct: Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsFee)
        : base(name, price)
        {
         CustomsFee = customsFee;
        }
        public override string PriceTag() 
        {
            return Name + " $ " + totalPrice() + " (Custom fee: $ " + CustomsFee + ")";
        }
        public double totalPrice()
        {
            return CustomsFee + Price;
        }
    }
}
