using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringExamples.ExtractMethod
{
    class ExtractMethod
    {
        private List<Order> _orders;
        private string _name;

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
            return _orders.Sum(order => order.GetAmount());
        }

        private void PrintDetails(decimal outstanding)
        {
            Console.Out.WriteLine("name: " + _name);
            Console.Out.WriteLine("amount: " + outstanding);
        }
    }
}
