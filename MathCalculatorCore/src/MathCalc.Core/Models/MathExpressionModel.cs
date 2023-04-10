using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalc.Core.Models
{
    public class MathExpressionModel
    {
        public double A {  get; set; }
        public double B { get; set; }
        public MathOperation Operation { get; set; }
    }
}
