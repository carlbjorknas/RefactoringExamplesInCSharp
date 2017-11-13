using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.IntroduceExplainingVariable
{
    class Example2Before
    {
        private int _quantity;
        private int _itemPrice;

        public double Price()
        {
            // price is base price - quantity discount + shipping
            return _quantity * _itemPrice -
                   Math.Max(0, _quantity - 500) * _itemPrice * 0.05 +
                   Math.Min(_quantity * _itemPrice * 0.1, 100);
        }
    }
}
