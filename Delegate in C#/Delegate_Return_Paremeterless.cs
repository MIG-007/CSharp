using System;
namespace Delegate{
    internal class Delegate_Return_Paremeterless{
        delegate int Calculate();
        public static void Main(string[] args){
            Calculate calc = new Calculate(MathV3.BitwiseOR);
            int result1 = calc();
            Console.WriteLine("Bitwise AND = " + result1);

            MathV3 math = new MathV3();
            calc = math.BitwiseAND;
            int result2 = calc.Invoke();
            Console.WriteLine("Bitwise OR = " + result2);

            int result3 = (result1 ^ result2);
            Console.WriteLine($"\n{result1} XOR {result2} = {result3}");
            Console.ReadKey();
        }
    }
    public class MathV3{
        public int BitwiseAND(){
            Console.Write("\nEnter first num : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second num : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            return (num1 & num2);
        }
        public static int BitwiseOR(){
            Console.Write("Enter first num : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second num : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            return (num1 | num2);
        }
    }
}
