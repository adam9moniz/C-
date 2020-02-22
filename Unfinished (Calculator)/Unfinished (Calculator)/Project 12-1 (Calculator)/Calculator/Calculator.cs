using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private Operator op;

        public enum Operator { Add, Subtract, Multiply, Divide, None };
        
        
        public Calculator()//constructer
        {
            this.currentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
            this.op = Operator.None;
        }

        public decimal CurrentValue //read only property
        {
            get { return this.currentValue; }
        }

        public void Clear()
        {
            this.currentValue = 0;
            this.operand1 = 0;
            this.operand2 = 0;
            this.op = Operator.None;
        }

        public void Add(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Add;
        }

        public void Subtract(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Subtract;
        }

        public void Multiply(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Multiply;
        }

        public void Divide(decimal val)
        {
            this.operand1 = val;
            this.currentValue = val;
            this.op = Operator.Divide;
        }

        public void Equals()
        {
            switch (this.op)
            {
                case Operator.Add:
                    currentValue = operand1 + operand2;
                    break;
                case Operator.Subtract:
                    currentValue = operand1 - operand2;
                    break;
                case Operator.Multiply:
                    currentValue = operand1 * operand2;
                    break;
                case Operator.Divide:
                    currentValue = operand1 / operand2;
                    break;
            }
            operand1 = currentValue;
        }

        public void Equals(decimal val)
        {
            operand2 = val;
            switch (this.op)
            {
                case Operator.Add:
                    currentValue = operand1 + operand2;
                    break;
                case Operator.Subtract:
                    currentValue = operand1 - operand2;
                    break;
                case Operator.Multiply:
                    currentValue = operand1 * operand2;
                    break;
                case Operator.Divide:
                    currentValue = operand1 / operand2;
                    break;
                case Operator.None:
                    currentValue = operand2;
                    break;
            }
            operand1 = currentValue;
        }

        public void SquareRoot(decimal val)
        {
            this.operand1 = val;
            currentValue = (decimal)Math.Sqrt(Convert.ToDouble(operand1));
            op = Operator.None;
        }

        public void Reciprocal(decimal val)
        {
            this.operand1 = val;
            currentValue = 1 / operand1;
            op = Operator.None;
        }

    }
}