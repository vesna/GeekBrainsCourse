using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework007
{
    internal class Calculator : ICalc
    {
        public event EventHandler<EventArgs>? GotResult;

        public int Result { get; private set; } = 0;
        private Stack<int> intStack = new Stack<int>();

        public Calculator(int result)
        {
            Result = result;
        }
        public void Divide(int value)
        {
            intStack.Push(Result);
            Result /= value;
            RiseEvent();
        }

        public void Multiply(int value)
        {
            intStack.Push(Result);
            Result *= value;
            RiseEvent();
        }

        public void Substruct(int value)
        {
            intStack.Push(Result);
            Result -= value;
            RiseEvent();
        }

        public void Sum(int value)
        {
            intStack.Push(Result);
            Result += value;
            RiseEvent();
        }

        private void RiseEvent()
        {
            GotResult?.Invoke(this, EventArgs.Empty);
        }

        public void CancelLast()
        {
            if (intStack.Count > 0)
            {
                Result = intStack.Pop();
                RiseEvent();
            }
        }
    }
}
