﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PasechnikPA1.Sprint1.Task4.V15.Lib
{
    public class DataService : ISprint1Task4V15
    {
        public double Calculate(double x, double y)
        {
            var res = (x + Math.Pow(y, 2)) / Math.Pow(Math.E, 2 - 4 * y);
            return Math.Round(res, 3); ;
        }
    }
}
