using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)    { Items.Add(item); }
        public void RemoveItem(OrderItem item) { Items.Remove(item); }
        
        public double Total()
        {
            return 2;
        }
    }
}
