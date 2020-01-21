using System;

namespace c0748465
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("state your number:");
            double UserInput = Convert.ToDouble(Console.ReadLine());
            Multiply m = new Multiply(UserInput);
        }
    }
    class Multiply
    {
        public Multiply(double UserInput)
        {
            Console.WriteLine("you are in constructer!");
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine("{0}times{1}={2}", UserInput, i, UserInput * i);

            }
        }
    }
}
