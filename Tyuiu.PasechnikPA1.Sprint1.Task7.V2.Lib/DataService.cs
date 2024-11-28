using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PasechnikPA1.Sprint1.Task7.V2.Lib
{
    public class DataService : ISprint1Task7V2
    {
        public double Calculate(double x, double y)
        {
            double res = (Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y)) * Math.Tan(x * y);
            double two = Math.Round(res, 3);
            return two; ;
        }
    }
}
