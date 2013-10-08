using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Exercise_9
{
    public class Order
    {
        public string CustomerName { get; set; }
        public decimal OrderTotal { get; set; }

        public decimal CalculateTotalOfOrders()
        {
            // Huge calculation going on here...
            Thread.Sleep(5);

            return OrderTotal;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random();

            IEnumerable<Order> orders = Enumerable.Range(1, 1000).Select(i => new Order
                {
                    CustomerName = "Customer" + i,
                    OrderTotal = random.Next(0, 1000)
                });

            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Calculation started");

            var totals = orders.Select(o => new {o.CustomerName, OrderTotal = o.CalculateTotalOfOrders()});

            foreach (var total in totals)
            {
                InvokeSomeWebService(total.CustomerName, total.OrderTotal);
            }

            long elapsed = sw.ElapsedMilliseconds;

            Console.Write("Finished in {0} ms", elapsed);
            Console.ReadKey();
        }

        private static void InvokeSomeWebService(string customerName, decimal orderTotal)
        {
            Thread.Sleep(5);
        }
    }
}