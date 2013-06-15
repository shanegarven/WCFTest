using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public double Add(int a, int b)
        {
            return (a + b);
        }

        public double Subtract(int a, int b)
        {
            return (a - b);
        }

        public double Multiply(int a, int b)
        {
            return (a*b);
        }

        /// <summary>
        /// Returns the value of "a" divided by "b" (a / b).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Divide(int a, int b)
        {
            return Convert.ToDouble((Convert.ToDouble(a)/Convert.ToDouble(b)));
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
