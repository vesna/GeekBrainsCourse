using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework008
{
    internal class Calculator : ICalc
    {
        public event EventHandler<EventArgs>? GotResult;

        public int Result { get; private set; } = 0;
        private Stack<int> intStack = new Stack<int>();
        private Stack<CalcActionLog> actionStack = new Stack<CalcActionLog>();

        public Calculator(int result)
        {
            Result = result;
        }
        public void Divide(int value)
        {
            if (value == 0)
            {
                actionStack.Push(new CalcActionLog(CalcAction.Divide, value));
                throw new CalculatorDivideByZeroException("Деление на ноль", actionStack);
            }
            intStack.Push(Result);
            Result /= value;
            RiseEvent();
        }

        public void Multiply(int value)
        {
            ulong tmp = (ulong)(Result * value);
            if (tmp > int.MaxValue)
            {
                actionStack.Push(new CalcActionLog(CalcAction.Multiply, value));
                throw new CalculateOperationCauseOverflowException("Переполнение int", actionStack);
            }
            intStack.Push(Result);
            Result *= value;
            RiseEvent();
        }

        public void Substruct(int value)
        {
            long tmp = (long)(Result - value);
            if (tmp < int.MinValue || (Result == int.MinValue && value == int.MaxValue))
            {
                actionStack.Push(new CalcActionLog(CalcAction.Substruct, value));
                throw new CalculateOperationCauseOverflowException("Переполнение int", actionStack);
            }
            intStack.Push(Result);
            Result -= value;
            RiseEvent();
        }

        public void Sum(int value)
        {
            long tmp = Result + value;
            if (tmp > int.MaxValue)
            {
                actionStack.Push(new CalcActionLog(CalcAction.Sum, value));
                throw new CalculateOperationCauseOverflowException("Переполнение int", actionStack);
            }
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

        public static double operator +(double obj1, Calculator obj2)
        {
            return (double)(obj1 + obj2.Result);
        }

        public static double operator *(double obj1, Calculator obj2)
        {
            return (double)(obj1 * obj2.Result);
        }

        public static double operator /(double obj1, Calculator obj2)
        {
            return (double)(obj2.Result/ obj1);
        }

        public static double operator -(double obj1, Calculator obj2)
        {
            return (double)(obj2.Result - obj1);
        }
    }
}
