using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 1;
            while (startValue <= stopValue)
            {
                sum += ((Math.Pow(value, 1)) + (5 / (1 + 4))) * Math.Sin(value);
                startValue++;
            }
            return Math.Round(sum, 3);
            
        }
    }
}
