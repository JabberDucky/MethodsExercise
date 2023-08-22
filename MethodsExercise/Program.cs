using System.Net.Security;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
			Exercise1();
			Exercise2();
        }

        public static void Exercise1()
        {
			Console.WriteLine("Hello User! Let's play a game!");
			Console.WriteLine("Answer the following questions!");
			Console.WriteLine("Enter a color");
			string color = Console.ReadLine();
			Console.WriteLine("Choose a plural body part (e.g. feet, arms, eyes, etc)");
			string body = Console.ReadLine();
			Console.WriteLine("Enter an adjective");
			string ad1 = Console.ReadLine();
			Console.WriteLine("Enter another adjective");
			string ad2 = Console.ReadLine();
			Console.WriteLine($"Which would you rather be A(n) {color} dinosaur with huge {body} or a(n) {ad1} griffin with {ad2} wings?");
			Console.WriteLine();
		}
		public static void Exercise2()
		{
            Console.WriteLine("Want to see some cool math facts? Hit enter to continue!");
			string math = Console.ReadLine();
			Console.WriteLine("Addition");
			Console.WriteLine(Add(2, 4, 6));
			Console.WriteLine();
			Console.WriteLine("Division");
			Console.WriteLine(Divide(10, 5));
			Console.WriteLine();
			Console.WriteLine("Multiplication");
			Console.WriteLine(Multiply(3, 4, 5, 1, 2));
			Console.WriteLine();
			Console.WriteLine("Subtraction");
			Console.WriteLine(Subtract(8, 4));
		}
		public static int Add(int num1, int num2, int num3)
		{
			return num1 + num2 + num3;
		}
		public static int Divide(int num1, int num2)
		{
			return num1 / num2;
		}
		public static int Multiply(int num1, int num2, int num3, int num4, int num5)
		{
			return num1 * num2 * num3 * num4 * num5;
		}
		public static int Subtract(int num1, int num2)
		{
			return num1 - num2;
		}
	}
}
