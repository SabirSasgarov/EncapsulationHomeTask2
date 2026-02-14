using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ClassTask12thFeb.Models
{
    internal class Order
    {
        public int Id;
        public string Name;
        public int Count;
        public double Price;

        public Order()
        {
            Count = 1;
        }
        public Order(int count)
        {
            this.Count = count;
        }
        public Order(int id, string name, int count, double price)
        {
            Id = id;
            Name = name;
            Count = count;
            Price = price;
        }

        public double GetTotal()
        {
            return Price * Count;
        }

        public void IncreaseCount(int n = 1)
        {
            Count += n;
        }

        public void ChangePrice(int newPrice, out double diff)
        {
            diff = newPrice - Price;
            Price = newPrice;
        }

        public override string ToString()
        {
            return $"Mehsul adi: {Name}, Mehsul ID: {Id}, Mehsul qiymeti: {Price}, Mehsul sayi: {Count}, Total: {GetTotal()}";
        }

    }
}
