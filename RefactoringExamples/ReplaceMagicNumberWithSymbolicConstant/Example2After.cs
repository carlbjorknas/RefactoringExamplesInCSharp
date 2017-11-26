using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.ReplaceMagicNumberWithSymbolicConstant
{
    class Example2After_User
    {
        private int _age = 0; // Just a dummy value to make the compiler happy
        private List<Comment> CommentsInLastHour => new List<Comment>(); // Just a dummy value to make the compiler happy

        const int CommenterMinAge = 13;
        const int MaxCommentsPerHour = 20;

        public bool AllowedToComment()
        {
            return _age >= CommenterMinAge && CommentsInLastHour.Count < MaxCommentsPerHour;
        }
    }
}
