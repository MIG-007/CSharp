using System;
namespace Delegate {
    internal class Delegate_Nonreturn_Parameterized {
        delegate void Calculate(int x, int y);
        public static void Main(string[] args) {
            Console.Write("Enter first num : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second num : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculate calc = new Calculate(MathV2.RightShift);
            calc.Invoke(num1, num2);

            MathV2 math = new MathV2();
            calc = math.LeftShift;
            calc(num1, num2);
            Console.ReadKey();
        }
    }
    public class MathV2 {
        public void LeftShift(int a, int b) {
            int result = a << b;
            Console.WriteLine($"{a} << {b} = {result}");
        }
        public static void RightShift(int a, int b) {
            int result = a >> b;
            Console.WriteLine($"{a} >> {b} = {result}");
        }       
    }
}
