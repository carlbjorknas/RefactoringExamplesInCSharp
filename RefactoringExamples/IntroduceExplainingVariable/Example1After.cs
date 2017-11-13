using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.IntroduceExplainingVariable
{
    class Example1After
    {       
        void Dummy(string platform, string browser, int resize)
        {
            bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
            bool isIEBrowser = browser.ToUpper().IndexOf("IE") > -1;
            bool wasResized = resize > 0;

            if (isMacOs && isIEBrowser && WasInitialized() && wasResized)
            {
                // do something
            }
        }

        // Dummy method just to make the code look like the example in the book and still compile
        private bool WasInitialized() => false;
    }
}
