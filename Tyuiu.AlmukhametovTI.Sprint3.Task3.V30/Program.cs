using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlmukhametovTI.Sprint3.Task3.V30.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint3.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #3                                                          *");
            Console.WriteLine("* Задание #3                                                         *");
            Console.WriteLine("* Вариант #30                                                        *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,  *");
            Console.WriteLine("* находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh  *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");
           
            string value = "fyyklbtyn ygrc vfyyyyh";
            char chr = 'y';          

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine($"Максимальное количество букв 'y', находящихся на соседних позициях: " + ds.GetMaxCharCount(value, chr));

            Console.ReadKey();
        }
    }
}
