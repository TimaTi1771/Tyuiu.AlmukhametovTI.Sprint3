using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            string input = "fyyklbtyn ygrc vfyyyyh";

            int maxCount = 0;
            int count = 0;

            foreach (char chr in value)
            {
                if (chr == 'y')
                {
                    count++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }

            maxCount = Math.Max(maxCount, count);

            return maxCount;
        }
    }
}



