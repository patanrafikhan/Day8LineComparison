using System;

namespace LinecomaparisonUC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            LengthofLine();
        }
        public static void LengthofLine() 
        {
            
            Console.WriteLine("Enter First Point ");
            Console.WriteLine("X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enter the Second Point");
            Console.WriteLine("X2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2=");
            double y2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------");

            double LengthofLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a Line is :{0}",LengthofLine);
        }
        
    }
}
