
internal class Program
{
    private static void Main(string[] args)
    {
        // even and odd number
        void Exercise1()
        {
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even number");
            }
            else
                Console.WriteLine(number + " is odd number");
        }

        //even number in rang 1 :10
        void Exercise2()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
            }
        }

        // Write a C# Sharp program to calculate the factorial of a given number.
        void Exercise3()
        {
            Console.Write("Enter Number : ");
            int fnumber = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            for (int i = 1; i <= fnumber; i++)
            {
                n *= i;
            }
            Console.Write(n);
        }

        //  Write a program in C# Sharp to display the n terms of even natural number and their

        void Exercise4()
        {
            int counter = 0;
            int sum = 0;
            Console.Write("Enter Number : ");
            int TermNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    counter++;
                    sum += i;
                    if (counter == TermNumber)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
        // Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n
        void Exercise5()
        {
            int SumSeries = 1;
            int Sum = 0;
            Console.Write("Enter Number : ");
            int Term = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Term; i++)
            {
                Console.WriteLine(SumSeries);
                Sum += SumSeries;
                SumSeries = (SumSeries * 10) + 1;
            }
            Console.WriteLine(Sum);
        }
        //call method 
        Exercise1();
    }
}

