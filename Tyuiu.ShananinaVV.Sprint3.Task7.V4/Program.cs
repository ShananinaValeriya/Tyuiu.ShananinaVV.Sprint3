using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShananinaVV.Sprint3.Task7.V4.Lib;

namespace Tyuiu.ShananinaVV.Sprint3.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Шананина В. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Шананина Валерия Викторовна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("* F(x) = ((2 * x + 6) / (Cos(x) + x)) - 3 на заданном диапазоне [-5 ; 5]  *");
            Console.WriteLine("* с шагом 1. Произвести проверку деления на ноль. При делении на ноль     *");
            Console.WriteLine("* вернуть значение 0. Значение округлить до двух знаков после запятой.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|     X    |    f(x)   |");
            Console.WriteLine("+----------+-----------+");


            for (int i = 0; i <= len -1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+----------+-----------+");
            //Console.WriteLine("[{0}]", string.Join(", ", valueArray));
            Console.ReadKey();

            
        }
    }
}
