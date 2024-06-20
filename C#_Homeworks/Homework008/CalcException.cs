using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework008
{
    internal class CalcException : Exception
    {
        public CalcException(string? message, Stack<CalcActionLog> actionLog) : base(message)
        {
            ActionLog = actionLog;
        }

        public CalcException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public Stack<CalcActionLog> ActionLog { get; private set; }

        public override string ToString()
        {
            return Message + ": " + string.Join("\n", ActionLog.Select(x => $"{x.CalcAction} {x.CalcArg}"));
        }
    }
}
