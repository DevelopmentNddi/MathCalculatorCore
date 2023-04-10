using MathCalc.Core;
using MathCalc.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalc.FromStringCalculation
{
    public class FromStingMathCalculator : IMathCalculation
    {
        public double Calculate(MathExpressionModel model)
        {
            switch (model.Operation)
            {
                case MathOperation.Add:
                    return model.A + model.B;
                    break;
                case MathOperation.Subtract:
                    return model.A - model.B;
                    break;
                case MathOperation.Multiply:
                    return model.A * model.B;
                    break;
                case MathOperation.Divide:
                    return model.A / model.B;
                    break;
                    default: throw new Exception();
            }
        }
        private double Add(double a, double b) {return a + b;}
        private double Subtract(double a, double b) {  return a - b; }
        private double Multiply(double a, double b) { return a * b; }
        private double Divide(double a, double b) { return a / b; }


    }
}
