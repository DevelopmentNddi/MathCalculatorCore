using MathCalc.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathCalc.Core
{
    public interface IMathCalculation
    {
        double Calculate(MathExpressionModel model);
    }
}
