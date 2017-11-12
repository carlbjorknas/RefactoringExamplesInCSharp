using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples
{
    class ExtractMethod
    {
        private List<Order> _orders;
        private string _name;


        //public void PrintOwing()
        //{
        //    Decimal outstanding = 0;

        //    // print banner
        //    Console.Out.WriteLine("*************************");
        //    Console.Out.WriteLine("***** Customer Owes *****");
        //    Console.Out.WriteLine("*************************");

        //    // calculate outstanding
        //    foreach (var order in _orders)
        //    {
        //        outstanding += order.GetAmount();
        //    }

        //    // print details
        //    Console.Out.WriteLine("name: " + _name);
        //    Console.Out.WriteLine("amount: " + outstanding);
        //}

        public void PrintOwing()
        {
            PrintBanner();
            var outstanding = GetOutstanding();
            PrintDetails(outstanding);
        }

        private void PrintBanner()
        {
            Console.Out.WriteLine("*************************");
            Console.Out.WriteLine("***** Customer Owes *****");
            Console.Out.WriteLine("*************************");
        }

        private decimal GetOutstanding()
        {
            Decimal outstanding = 0;
            foreach (var order in _orders)
            {
                outstanding += order.GetAmount();
            }
            return outstanding;
        }

        private void PrintDetails(decimal outstanding)
        {
            Console.Out.WriteLine("name: " + _name);
            Console.Out.WriteLine("amount: " + outstanding);
        }

        //private decimal GetOutstanding()
        //{
        //    return _orders.Sum(order => order.GetAmount());
        //}
    }

    class Order
    {
        public decimal GetAmount() => 0;
    }
}
