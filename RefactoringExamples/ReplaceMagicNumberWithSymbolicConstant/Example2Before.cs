using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.ReplaceMagicNumberWithSymbolicConstant
{
    class Example2Before_User
    {
        private int _age = 0; // Just a dummy value to make the compiler happy
        private List<Comment> CommentsInLastHour => new List<Comment>(); // Just a dummy value to make the compiler happy

        public bool AllowedToComment()
        {
            return _age > 13 && CommentsInLastHour.Count <= 20;
        }
    }
}
