using System;
namespace SimilarityAndDistanceAlgorithms{
    internal class Cosine{
        static void Main(string[] args){
            double[] arr1 = { 5, 4, 2, 1 };
            double[] arr2 = { 1, 3, 2, 4 };
            var result = CalcCosine(arr1, arr2);
            Console.WriteLine($"Cosine Similarity : {result.cs.ToString("0.00")}");
            Console.WriteLine($"Cosine Distance : {result.cd.ToString("0.00")}");
            Console.ReadKey();
        }
        private static (double cs, double cd) CalcCosine(double[] arr1, double[] arr2){
            if (arr1.Length != arr2.Length){
                Console.WriteLine("Error : Arrays must have the same length.");
                return (0, 0);
            }
            double dotProduct = 0.0, xSumAbsSquare = 0, ySumAbsSquare = 0;
            for (int i = 0; i < arr1.Length; i++){
                dotProduct += arr1[i] * arr2[i];
                xSumAbsSquare += Math.Pow(Math.Abs(arr1[i]), 2);
                ySumAbsSquare += Math.Pow(Math.Abs(arr2[i]), 2);
            }
            double cs = dotProduct/(Math.Sqrt(xSumAbsSquare) * Math.Sqrt(ySumAbsSquare));
            return (cs, 1-cs);
        }
    }
}
