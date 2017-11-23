using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.ReplaceMagicNumberWithSymbolicConstant
{
    class Example1Before
    {
        double PotentialEnergy(double mass, double height)
        {
            return mass * 9.81 * height;
        }
    }
}
