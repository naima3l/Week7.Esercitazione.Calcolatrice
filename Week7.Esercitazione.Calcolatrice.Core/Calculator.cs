using System;

namespace Week7.Esercitazione.Calcolatrice.Core
{
    public class Calculator
    {
        public double Sum(double[] numbers)
        {
            return numbers[0] + numbers[1];
        }

        //triplo slash per fare il summary
        /// <summary> 
        /// Questo metodo fa la divisione tra number e se i number sono zero, restituisce null
        ///  </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public double? Div(double[] numbers)
        {
            if (numbers[0] == 0 && numbers[1] == 0)
            {
                return null;
            }
            if (numbers[1] == 0)
            {
                return null;
            }
            
            return numbers[0] / numbers[1];
        }

        public double Subtraction(double[] numbers)
        {
            return numbers[0] - numbers[1];
        }

        public double Multiiplication(double[] numbers)
        {
            return numbers[0] * numbers[1];
        }

        public bool VerificaSeAMaggioreDiB(double v1, double v2)
        {
            if (v1 >= v2)
            {
                return true;
            }
            else return false;
        }

       
    }
}

