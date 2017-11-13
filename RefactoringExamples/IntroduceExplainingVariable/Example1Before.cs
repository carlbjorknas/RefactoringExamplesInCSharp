using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.IntroduceExplainingVariable
{
    class Example1Before
    {       
        void Dummy(string platform, string browser, int resize)
        {
            if (platform.ToUpper().IndexOf("MAC") > -1 &&
                browser.ToUpper().IndexOf("IE") > -1 &&
                WasInitialized() && resize > 0)
            {
                // do something
            }
        }

        // Dummy method just to make the code look like the example in the book and still compile
        private bool WasInitialized() => false;
    }
}
