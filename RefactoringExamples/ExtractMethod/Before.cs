using System;
using System.Collections.Generic;

namespace RefactoringExamples.ExtractMethod
{
    class Before
    {
        private List<Order> _orders;
        private string _name;

        public void PrintOwing()
        {
            Decimal outstanding = 0;

            // print banner
            Console.Out.WriteLine("*************************");
            Console.Out.WriteLine("***** Customer Owes *****");
            Console.Out.WriteLine("*************************");

            // calculate outstanding
            foreach (var order in _orders)
            {
                outstanding += order.GetAmount();
            }

            // print details
            Console.Out.WriteLine("name: " + _name);
            Console.Out.WriteLine("amount: " + outstanding);
        }
    }
}
