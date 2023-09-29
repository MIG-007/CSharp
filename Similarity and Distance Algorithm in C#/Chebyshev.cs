using System;
namespace SimilarityAndDistanceAlgorithms {
    internal class Chebyshev {
        static void Main(string[] args) {
            double[] arr1 = { 1.5, 4, 2, 2 };
            double[] arr2 = { 1, 6, 3, 1.4 };
            double result = CalcChebyshev(arr1, arr2);
            Console.WriteLine($"Chebyshev Distance : {result.ToString("0.00")}");
            Console.ReadKey();
        }

        private static double CalcChebyshev(double[] arr1, double[] arr2) {
            if (arr1.Length != arr2.Length) {
                Console.WriteLine("Error : Arrays must have the same length.");
                return 0;
            }
            double distance = 0.0;
            for (int i = 0; i < arr1.Length; i++) {
                distance = Math.Max(distance, Math.Abs(arr1[i] - arr2[i]));
            }
            return distance;
        }
    }
}
