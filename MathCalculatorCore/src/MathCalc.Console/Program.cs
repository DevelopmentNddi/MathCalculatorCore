// See https://aka.ms/new-console-template for more information

using MathCalc.Console;
using MathCalc.Core;
using MathCalc.FromStringCalculation;

IMathCalculation fromStringMathCalculator = new FromStingMathCalculator();

var calc = new MathCalculation(fromStringMathCalculator);

Console.WriteLine(calc.Calculate("5+2"));