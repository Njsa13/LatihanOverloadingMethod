using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugasmemberclass
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            if(number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int kecil;
            if(number1 < number2)
            {
                kecil = number1;
                if(number1 > (int)number3)
                {
                    kecil = (int)number3;
                }

            } else
            {
                kecil = number2;               
                if (number2 > (int)number3)
                {
                    kecil = (int)number3;
                }
            }
            return kecil;
        }

        public int FindMaximum(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int besar;
            if (number1 > number2)
            {
                besar = number1;
                if (number1 < (int)number3)
                {
                    besar = (int)number3;
                }

            }
            else
            {
                besar = number2;
                if (number2 < (int)number3)
                {
                    besar = (int)number3;
                }
            }
            return besar;
        }
    }
}
