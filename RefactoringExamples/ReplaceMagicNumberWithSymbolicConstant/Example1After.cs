using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.ReplaceMagicNumberWithSymbolicConstant
{
    class Example1After
    {
        private const double GravitationalConstant = 9.81;

        double PotentialEnergy(double mass, double height)
        {
            return mass * GravitationalConstant * height;
        }
    }
}
