using ClassTask12thFeb.Models;

namespace ClassTask12thFeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order book = new Order(9);
            book.Id = 45;
            book.Name = "Dune Prophet";
            book.Price = 20;
            #region part1
            //book.IncreaseCount(10);
            //Console.WriteLine("Ilk elaveden sonra yeni kitab sayi: " + book.Count);

            //book.IncreaseCount();
            //Console.WriteLine("Ikinci elaveden sonra yeni kitab sayi: " + book.Count);

            //Console.WriteLine(book.ToString());
            #endregion

            #region part2
            double diff;
            book.ChangePrice(out diff);
            Console.WriteLine("Aradaki ferq: "+ diff);
            Console.WriteLine($"Yeni qiymet: {book.Price}");
            #endregion

            //OnlineOrder onlineOrder = new OnlineOrder(1, "defter", 2, 15, 12, 3);
            //Console.WriteLine(onlineOrder.ToString());




        }

    }
}
