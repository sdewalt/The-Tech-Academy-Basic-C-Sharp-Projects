using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsIVAssignment
{
    public class optionalInteger
    {
        public int Add(int userInput1, int userInput2 = 3)
        {
            int result = userInput1 + userInput2;

            return result;
        }
    }
}
