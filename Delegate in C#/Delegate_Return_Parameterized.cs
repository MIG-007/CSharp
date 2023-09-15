using System;
using System.Linq;
namespace Delegate{
    delegate float Calculate(int[] arr);
    internal class Delegate_Return_Parameterized{
        public static void Main(string[] args){
            int[] arr = { 10, 2, 4, 7 };
            Calculate calc = HarmonicSum;
            float sum = calc(arr);
            Console.WriteLine($"Harmonic Sum : {sum}");
            float mean = arr.Length / sum;
            Console.WriteLine($"Harmonic Mean : {mean}");
            Console.ReadKey();
        }
        public static float HarmonicSum(int[] arr){
            return arr.Select(x => 1 / (float)x).Sum();
        }
    }
}
