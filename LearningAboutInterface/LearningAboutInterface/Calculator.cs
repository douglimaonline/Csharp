using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAboutInterface
{
    internal class Calculator
    {
        List<BinOperations> Operations = new List<BinOperations>()
        {
            new Sum(),
            new Sub(),
            new Multiply(),
        };

        public int UseCalculator(string NameOper, int a, int b)
        {
            int result = 0;
            if (NameOper == "sum")
            {
                result = Operations[0].Operation(a, b);
            }
            else if (NameOper == "sub")
            {
                result = Operations[1].Operation(a, b);
            }
            else { result = Operations[2].Operation(a, b); }
            
            return result;
        }
    }
}
