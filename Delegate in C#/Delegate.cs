using System;

namespace Delegate {    
    public delegate void Drink();               //1.Create Delegate
    internal class Program {
        static void Main(string[] args) {
            ////3.Set target method by using object access
            //Drink table1 = new Drink(Restaurant.DrinkWater);    //Static member access
            //table1();                                           //4.Invoke Delegate
            //table1 = Restaurant.DrinkLemonade;      //Override reference address
            //table1.Invoke();

            //Restaurant rst = new Restaurant();     //Creating Object for instance members
            ////3.Set target method by using direct access
            //Drink table2 = rst.DrinkBeer;          //Instance member access
            //table2.Invoke();                       //4.Invoke Delegate
            //table2 = rst.DrinkWhisky;               //Override reference address
            //table2();

            Drink drink = new Drink(Restaurant.DrinkWater);
            drink();

            drink = Restaurant.DrinkLemonade;
            drink.Invoke();

            Restaurant rst = new Restaurant();
            drink = rst.DrinkBeer;
            drink();

            drink = rst.DrinkWhisky;
            drink.Invoke();
            Console.ReadKey();
        }       
    }
    public class Restaurant {
        //2.Create Target Methods
        public static void DrinkWater(){            //Static member
            Console.WriteLine("Drink Water.");
        }
        public static void DrinkLemonade(){         //Static member
            Console.WriteLine("Drink Lemonade.");
        }
        public void DrinkBeer(){                    //Instance member
            Console.WriteLine("Drink Beer.");
        }
        public void DrinkWhisky(){                  //Instance member
            Console.WriteLine("Drink Whisky.");
        }
    }
}
