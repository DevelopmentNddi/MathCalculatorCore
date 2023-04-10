using MathCalc.Core;
using MathCalc.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MathCalc.Console
{
    internal class MathCalculation
    {
        private static char[] _operations = new[] { '*', '/', '+', '-' }; 
        private readonly IMathCalculation calculator;

        public MathCalculation(IMathCalculation calculator)
        {
            this.calculator = calculator;
        }
        public double Calculate(string expression)
        {
            var operation = expression.FirstOrDefault(x=> _operations.Contains(x));
            var e = expression.Split(operation,  StringSplitOptions.RemoveEmptyEntries);
            var model = new MathExpressionModel()
            {
                A = double.Parse(e[0]),
                B = double.Parse(e[1]),
                Operation = Parse(operation)
            };
          

            return calculator.Calculate(model);
        }

        private MathOperation Parse(char symbol)
        {
            return symbol switch
            {
                '+' => MathOperation.Add,
                '-' => MathOperation.Subtract,
                '*' => MathOperation.Multiply,
                '/' => MathOperation.Divide,
                _ => throw new ArgumentOutOfRangeException(nameof(symbol))
            };
        }
    }
}
