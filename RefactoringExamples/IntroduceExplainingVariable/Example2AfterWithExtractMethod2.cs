using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.IntroduceExplainingVariable
{
    class Example2AfterWithExtractMethod2
    {
        private int _quantity;
        private int _itemPrice;

        public double Price()
            => BasePrice - QuantityDiscount + Shipping;

        private int BasePrice 
            => _quantity * _itemPrice;

        private double QuantityDiscount 
            => Math.Max(0, _quantity - 500) * _itemPrice * 0.05;

        private double Shipping
            => Math.Min(_quantity * _itemPrice * 0.1, 100);
    }
}
