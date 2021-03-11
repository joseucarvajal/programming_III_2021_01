using System;
namespace Programming_III.Recursion
{
    public class Add
    {
        public static void Main1(String[] args)
        {
            int n1 = 8;
            int n2 = 4;
            int total = Multiply2Numbers(n1, n2, 0);
            Console.WriteLine("Total is: " + total);
        }

        public static int Multiply2Numbers(int n1, int n2, int total)
        {
            //1. Base case
            if(n1 == 0)
            {
                return total;
            }

            //2. Solve problem partially
            total = total + n2;

            //3. Make the problem smaller
            return Multiply2Numbers(n1 - 1, n2, total);
        }
    }
}
