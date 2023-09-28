using System;

namespace SimilarityAndDistanceAlgorithms
{
    internal class Euclidean
    {
        public static void Main(string[] args)
        {
            double[] arr1 = { 1.5, 4, 2, 2};
            double[] arr2 = { 1, 3, 2, 1.4 };
            double result = CalcEuclidean(arr1, arr2);
            Console.WriteLine($"Euclidean Distance : {result.ToString("0.00")}");
            Console.ReadKey();
        }

        private static double CalcEuclidean(double[] arr1, double[] arr2)
        {
            if(arr1.Length != arr2.Length){
                Console.WriteLine("Error : Arrays must have the same length.");
                return 0;
            }
            double sumOfSquares = 0;
            for (int i = 0; i < arr1.Length; i++){
                sumOfSquares += Math.Pow(arr1[i] - arr2[i], 2);
            }
            return Math.Sqrt(sumOfSquares);
        }
    }
}
