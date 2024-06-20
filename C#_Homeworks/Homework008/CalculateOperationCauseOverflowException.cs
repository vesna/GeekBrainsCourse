using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework008
{
    internal class CalculateOperationCauseOverflowException : CalcException
    {
        public CalculateOperationCauseOverflowException(string v, Stack<CalcActionLog> actionLog) : base(v, actionLog)
        {

        }

        public CalculateOperationCauseOverflowException(string v, Exception e) : base(v, e)
        {

        }
    }
}
