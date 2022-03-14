using System;

namespace PlayingWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------Exercise 1---------------
            //Name: Sean
            //Favorite Color: Blue
            //Favorite animal: Wolf
            //Favorite Band: Green Day

            //Console.WriteLine("Hello - What is your first name?");
            //var userName = Console.ReadLine();

            //Console.WriteLine($"Hi, {userName}. What is your favorite color?");
            //var color = Console.ReadLine();

            //Console.WriteLine($"{color} is an awesome color. What is your favorite animal?");
            //var animal = Console.ReadLine();

            //Console.WriteLine("Great! Now, what is your favorite band?");
            //var band = Console.ReadLine();

            //Console.WriteLine($"Thanks, {userName}! Here is your profile");
            //Console.WriteLine("-----------------------");

            //Console.WriteLine($"Name: {userName}");
            //Console.WriteLine($"Favorite color: {color}");
            //Console.WriteLine($"Favorite animal: {animal}");
            //Console.WriteLine($"Favorite band: {band}");


            //---------------Exercise 2---------------

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1= int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }

        //---------------Exercise 2---------------
        
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        //---------------Exercise 2 Challenge---------------

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }
    }
}
