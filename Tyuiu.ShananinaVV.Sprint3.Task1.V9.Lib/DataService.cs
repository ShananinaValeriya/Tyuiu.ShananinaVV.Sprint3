using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShananinaVV.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res2 = 1;

            while (startValue <= stopValue)
            {

                res2 = res2 * (Math.Pow((300 / ((Math.Cos(value) + Math.Pow(value, startValue)))), startValue));
                //res2 = res2 * ((Math.Pow(300, startValue) ) / (Math.Pow((Math.Cos(value) + Math.Pow(value, startValue)), startValue)));
                startValue++;
            }
            return Math.Round(res2, 3);
        }
    }
}
