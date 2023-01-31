using System;

namespace LineComparisonUC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            LengthofLineOne();
            
        }
        public static void LengthofLineOne()
        {

            Console.WriteLine("Enter First Point ");
            Console.WriteLine("X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");


            Console.WriteLine("Enter the Second Point");
            Console.WriteLine("X2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("##########################");

            Console.WriteLine("Enter the values of Second Line");


            Console.WriteLine("Enter First Point ");
            Console.WriteLine("X3=");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y3=");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$");


            Console.WriteLine("Enter the Second Point");
            Console.WriteLine("X4=");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y4=");
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************************");

            double LengthofLineOne = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a Line is :{0}", LengthofLineOne);
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&");

            double LengthofLineTwo = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of a Line is :{0}", LengthofLineTwo);

            if (LengthofLineOne.Equals(LengthofLineTwo))
            {
                Console.WriteLine("First Line and Second Lines are Equal");
            }
        }

    }


}

