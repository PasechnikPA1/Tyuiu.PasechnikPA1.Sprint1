﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PasechnikPA1.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            return (a / c) * (b / c);
        }
    }
}
