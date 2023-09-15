using System;

namespace Delegate {
    internal class Delegate_Nonretun_Parameterless {
        public delegate void Calculator();
        static void Main(string[] args) {
            Calculator calc = new Calculator(MathV1.Add);
            calc();
            MathV1 math = new MathV1();
            calc = math.Sub;
            calc.Invoke();
            Console.ReadKey();
        }
    }
    public class MathV1 {
        public static void Add(){
            Console.Write("Enter first num : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second num : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum : " + sum);
        }
        public void Sub(){
            Console.Write("\nEnter first num : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second num : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sub = num1 - num2;
            Console.WriteLine("Sub : " + sub);
        }
    }
}
