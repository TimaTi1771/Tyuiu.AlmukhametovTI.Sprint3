using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task2.V1.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 1;
            int i = 1;
            do
            {
                s *= ((Math.Sin(i)) * (Math.Pow((1 / 2), 2)));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(s, 3);           
        }
    }
}
