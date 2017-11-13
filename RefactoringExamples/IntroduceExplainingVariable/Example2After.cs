using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.IntroduceExplainingVariable
{
    class Example2After
    {
        private int _quantity;
        private int _itemPrice;

        public double Price()
        {
            var basePrice = _quantity * _itemPrice;
            var quantityDiscount = Math.Max(0, _quantity - 500) * _itemPrice * 0.05;
            var shipping = Math.Min(_quantity * _itemPrice * 0.1, 100);
            return basePrice - quantityDiscount + shipping;
        }
    }
}
