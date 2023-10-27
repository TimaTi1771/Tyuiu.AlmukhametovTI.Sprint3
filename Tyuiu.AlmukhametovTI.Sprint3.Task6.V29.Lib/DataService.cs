using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task6.V29.Lib
{
    public class DataService : ISprint3Task6V29
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for ( x = startValue; x <= stopValue; x++)
            {
                for ( int f = 1; f <= x; f++)
                {
                    if (x % f == 0)
                    {
                        sum += f;
                    }
                }
            }
            return sum;
        }
    }
}
