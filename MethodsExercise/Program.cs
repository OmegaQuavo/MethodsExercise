using System.Globalization;

namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {   
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine($"So, {name}, whats your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("Nice! Lastly I was wondering what your favorite animal is?");
            string animal = Console.ReadLine();

            Console.WriteLine($"Once upon a time, {name} was walking down the street to see their favorite band, {band}. Suddenly, out of no where, came a {color} {animal}! {name} was shocked beyond all belief, and spent the next hour admiring the animal, looking for where it came from. Sadly, {name} had lost track of time and completely forgotten they had purchased tickets to see {band} and had missed the show. Nobody ever came to claim ownership of the {color} {animal} and so {name} decided to take it home, and they lived happily ever after");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //Madlib();
            //Console.WriteLine(Add(2, 2));
            //Console.WriteLine(Subtract(2, 2));
            //Console.WriteLine(Multiply(2, 2));
            //Console.WriteLine(Divide(2, 2));
            Console.WriteLine(Sum(5, 5, 5));
        }
    }
}
