using System;

namespace LineComparisionUC3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            LengthofLine();

            Console.WriteLine(1.CompareTo(1));
            Console.WriteLine(1.CompareTo(2));
            Console.WriteLine(2.CompareTo(1));
        }
        public static void LengthofLine()
        {

            Console.WriteLine("Enter First Point ");
            Console.WriteLine("X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&");


            Console.WriteLine("Enter the Second Point");
            Console.WriteLine("X2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("**************************");

            Console.WriteLine("Enter the values of Second Line");


            Console.WriteLine("Enter First Point ");
            Console.WriteLine("X3=");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y3=");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%");


            Console.WriteLine("Enter the Second Point");
            Console.WriteLine("X4=");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y4=");
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");

            double LengthofLineOne = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a Line is :{0}", LengthofLineOne);
            Console.WriteLine("#######################");

            double LengthofLineTwo = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Length of a Line is :{0}", LengthofLineTwo);
            //int Result = LengthofLineOne.CompareTo(LengthofLineTwo);    

            if (LengthofLineOne.Equals(LengthofLineTwo))
            {
                Console.WriteLine("First Line is Greater than Second Line :");
            }
            else if (LengthofLineOne.Equals(LengthofLineTwo))
            {
                Console.WriteLine("Second Line is Greater than First Line :");
            }
            else
            {
                Console.WriteLine("First Line and Second Line are Equal :");
            }
        }


    }
}
