using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework008
{
    internal class CalcActionLog
    {
        public CalcAction CalcAction {  get; private set; }
        public int CalcArg { get; private set; }
        public CalcActionLog(CalcAction action, int arg) { 
            this.CalcAction = action;
            this.CalcArg = arg;
        }
    }
}
