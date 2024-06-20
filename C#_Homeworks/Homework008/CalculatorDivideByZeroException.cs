using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework008
{
    internal class CalculatorDivideByZeroException : CalcException
    {
        public CalculatorDivideByZeroException(string v, Stack<CalcActionLog> actionLog) : base(v, actionLog)
        {
            
        }

        public CalculatorDivideByZeroException(string v, Exception e) : base(v, e)
        {

        }
    }
}
