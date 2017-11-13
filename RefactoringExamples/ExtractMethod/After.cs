using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.ExtractMethod
{
    class After
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
    }
}
