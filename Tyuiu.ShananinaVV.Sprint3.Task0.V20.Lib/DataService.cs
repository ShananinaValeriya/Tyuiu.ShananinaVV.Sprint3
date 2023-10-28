using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShananinaVV.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                //res = res *  ((Math.Cos(value)) + (Math.Pow((i / 8), 3)));
                res = res * ((Math.Cos(value)) + ((Math.Pow(i, 3)) / (Math.Pow(8, 3))));
            }
            return Math.Round(res, 3);
        }
    }
}
