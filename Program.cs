using System;

namespace CheckEqualsCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3, x4, y4;

            Console.WriteLine("Enter inputs for the first line");
            Console.WriteLine("Input the X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            double lineLength1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine("Length of the first line = " + lineLength1);

            Console.WriteLine("Enter inputs for the second line");
            Console.WriteLine("Input the X1: ");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y1: ");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the X2: ");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y2: ");
            y4 = Convert.ToInt32(Console.ReadLine());

            double lineLength2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
            Console.WriteLine("Length of the second line = " + lineLength2);

            if (lineLength1 == lineLength2)
            {
                Console.WriteLine("Both lines are equal in length");
            }
            else
            {
                Console.WriteLine("Lines are Not Equal in length");
            }
        }
    }
}
using System;

namespace CheckEqualsCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3, x4, y4;

            Console.WriteLine("Enter inputs for the first line");
            Console.WriteLine("Input the X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            double lineLength1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            Console.WriteLine("Length of the first line = " + lineLength1);

            Console.WriteLine("Enter inputs for the second line");
            Console.WriteLine("Input the X1: ");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y1: ");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the X2: ");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Y2: ");
            y4 = Convert.ToInt32(Console.ReadLine());

            double lineLength2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
            Console.WriteLine("Length of the second line = " + lineLength2);

            if (lineLength1 == lineLength2)
            {
                Console.WriteLine("Both lines are equal in length");
            }
            else
            {
                Console.WriteLine("Lines are Not Equal in length");
            }
        }
    }
}
