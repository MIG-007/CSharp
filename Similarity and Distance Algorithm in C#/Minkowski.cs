using System;
namespace SimilarityAndDistanceAlgorithms {
    internal class Minkowski {
        static void Main(string[] args) {
            double[] arr1 = { 1.5, 4, 2, 2 };
            double[] arr2 = { 1, 3, 2, 1.4 };
            int norm = 3;
            double result = CalcMinkowski(arr1, arr2, norm);
            Console.WriteLine($"Minkowski Distance : {result.ToString("0.00")}");
            Console.ReadKey();
        }
        private static double CalcMinkowski(double[] arr1, double[] arr2, float p)
        {
            if (arr1.Length != arr2.Length){
                Console.WriteLine("Error : Arrays must have the same length.");
                return 0;
            }
            double sumOfAbsSquareNorm = 0.0;
            for (int i = 0; i < arr1.Length; i++){
                sumOfAbsSquareNorm += Math.Pow(Math.Abs(arr1[i] - arr2[i]), p);
            }
            return Math.Pow(sumOfAbsSquareNorm, 1/p);
        }
    }
}
