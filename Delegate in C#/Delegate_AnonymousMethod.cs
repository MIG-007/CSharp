using System;
namespace Delegate{
    internal class Delegate_AnonymousMethod{
        delegate void Calc1(int a, int b, int c);   //NonReturn and Parameterized
        delegate double Calc2(int b, int h);        //Return and Parameterized
        delegate void Calc3();                      //NonReturn and Parameterless
        delegate double Calc4();                    //Return and Parameterless
        delegate double Calc5(int num);             //Recursive Method
        public static void Main(string[] args){
            Console.Write("Enter A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter C : ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter H : ");
            int h = Convert.ToInt32(Console.ReadLine());

            //Non-Return and Parameterized Method
            Calc1 obj1 = delegate (int x, int y, int z) {
                Console.WriteLine($"Perimeter of Triangle: {z + y + z}");
            };
            obj1(a, b, c);

            //Return and Parameterized Method
            Calc2 obj2 = delegate (int x, int y) {
                return 0.5 * x * y;
            };
            double area_triangle = obj2(b, h);
            Console.WriteLine($"Area of Triangle : {area_triangle}");

            //Non-Return and Parameterless Method
            Calc3 obj3 = delegate () {
                Console.Write("\nEnter radius : ");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Area of Circle : {3.14159 * r * r}");
            };
            obj3();

            //Return and Parameterless Method
            Calc4 obj4 = delegate () {
                Console.Write("\nEnter radius : ");
                int r = Convert.ToInt32(Console.ReadLine());
                return (2 * 3.14159 * r);
            };
            double perimeter_circel = obj4();
            Console.WriteLine($"Perimeter of Circel : {perimeter_circel}");

            //Recursive Method
            Console.Write("\nEnter num : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Calc5 obj5 = delegate (int x){
                double RecursiveSum(int y){
                    return (y == 1) ? 1 : Math.Pow(y, y) + RecursiveSum(y - 1);
                }
                return RecursiveSum(x);
            };
            double sum = obj5(num);
            Console.WriteLine($"Sum of Series : {sum}");
            Console.ReadKey();
        }
    }
}
