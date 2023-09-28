using System;

namespace SimilarityAndDistanceAlgorithms 
{
    internal class Manhattan
    {
        static void Main(string[] args)
        {
            double[] arr1 = { 1.5, 4, 2, 2 };
            double[] arr2 = { 1, 3, 2, 1.4 };
            double result = CalcManhattan(arr1, arr2);
            Console.WriteLine($"Manhattan Distance : {result.ToString("0.00")}");
            Console.ReadKey();
        }

        private static double CalcManhattan(double[] arr1, double[] arr2)
        {
            if (arr1.Length != arr2.Length){
                Console.WriteLine("Error : Arrays must have the same length.");
                return 0;
            }
            double sumOfAbs = 0.0;
            for (int i = 0; i < arr1.Length; i++){
                sumOfAbs += Math.Abs(arr1[i] - arr2[i]);
            }
            return sumOfAbs;
        }
    }
}
