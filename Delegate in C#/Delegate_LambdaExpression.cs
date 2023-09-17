using System;
namespace Delegate{
    //1.Create Delegates    
    delegate void Calc1(int w, int h);		//NonReturn and Parameterized
    delegate int Calc2(int w, int h);	    //Return and Parameterized
    delegate void Calc3();			        //NonReturn and Parameterless
    delegate int Calc4();                   //Return and Parameterless
    delegate int Calc5(int num);            //Recursive Method
    internal class Delegate_LambdaExpression{
        public static void Main(string[] args){
            Console.Write("Enter width : ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter height : ");
            int h = Convert.ToInt32(Console.ReadLine());

            //Expression Lambda - NonReturn and Parameterized
            Calc1 rect1 = (int a, int b) => Console.WriteLine($"Area of Rectangle : {a * b}");
            rect1(w, h);

            //Statement Lambda - Return and Parameterized
            Calc2 rect2 = (int a, int b) => {
                return (2 * a) + (2 * b);
            };
            int rect_perimeter = rect2(w, h);
            Console.WriteLine($"Perimeter of Rectangel : {rect_perimeter}");

            //Statement Lambda - NonReturn and Parameterless
            Calc3 square1 = () => {
                Console.Write("\nEnter size : ");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Area of Square : {s*s}");
            };
            square1();

            //Statement Lambda - Return and Parameterless
            Calc4 square2 = () => {
                Console.Write("\nEnter size : ");
                int s = Convert.ToInt32(Console.ReadLine());
                return (4*s);
            };
            int square_perimeter = square2();
            Console.WriteLine($"Perimeter of Square : {square_perimeter}");

            //Statement Lambda - Recursive Method
            Console.Write("\nEnter num : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Calc5 recursive = (int a) => {                 
                int RecursiveSum(int b){    //Local Function
                    return (b == 1) ? 1 : b + RecursiveSum(b - 1);
                }
                return RecursiveSum(a);
            };
            int sum = recursive(num);
            Console.WriteLine($"Sum of Series : {sum}");

            Console.ReadKey();
        }
    }
}
