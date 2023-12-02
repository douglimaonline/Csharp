using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAboutInterface
{
    internal interface BinOperations
    {
        int Operation(int a, int b);
    }

    class Sum : BinOperations
    {
        public int Operation(int a, int b)
        {
            return a + b;
        }
    }

    class Sub : BinOperations
    {
        public int Operation(int a, int b)
        {
            return a - b;
        }
    }

    class Multiply : BinOperations
    {
        public int Operation(int a, int b)
        {
            return a * b;
        }
    }
}