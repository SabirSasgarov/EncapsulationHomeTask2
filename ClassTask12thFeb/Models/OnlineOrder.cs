using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask12thFeb.Models
{
    internal class OnlineOrder : Order
    {
        public int Distance;
        public int CattirmaPulu;

        public OnlineOrder(int id, string name, int count, double price, int distance, int cattirmaPulu):base(id,name,count,price)
        {
            Distance = distance;
            CattirmaPulu = cattirmaPulu;
        }

        public int TotalCatdirmaPulu()
        {
            int total = default;
            if (Distance % 5 > 0)
                total = (Distance / 5 + 1)*CattirmaPulu;
            else
                total = (Distance / 5)*CattirmaPulu;
            return total;
        }
        public override string ToString()
        {
            return $"Mehsulun adi: {Name}, Mehsul ID: {Id}, Mehsul qiymeti: {Price}, Mehsul sayi: {Count}, " +
                $"Total: {GetTotal()}, Cattirma Pulu: {TotalCatdirmaPulu()}, Umumi: {GetTotal()+TotalCatdirmaPulu()}\n";
        }


    }
}
