using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static double  result = double.NaN;
        public static double DoCalculation(double oprend1, double oprend2, char operation) {
            switch(operation){
                case 'a':
                    result = oprend1 + oprend2;
                    break;
                case 's':
                    result = oprend1 - oprend2;
                    break;
                case 'p':
                    result = oprend1 * oprend2;
                    break;
                case 'd':
                    while (oprend2 == 0 ) {
                    
                    }
                    result = oprend1 / oprend2;
                    break;
            }
            return result;

        }
    }
}
