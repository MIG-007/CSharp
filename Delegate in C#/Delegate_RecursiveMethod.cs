using System;
namespace Delegate{
    internal class Delegate_RecursiveMethod{
        delegate int Calculate(int num);
        public static void Main(string[] args){
            Console.Write("Enter num : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Calculate calc = Factorial;
            int result = calc.Invoke(num);
            Console.WriteLine($"Factorial : {result}");
            Console.ReadKey();
        }
        static int Factorial(int num){
            return (num == 1) ? 1:(num * Factorial(num - 1));
        }
    }
}
