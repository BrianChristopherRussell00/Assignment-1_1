using Microsoft.VisualBasic;

namespace Assignment_1_1
{//Assignment 1-1
    internal class Program
    {
        static void Main(string[] args)
        {
            double phoneNumber;
            int arrayNum;
            double myDoubleNum = 5.99;
            int mynumber = 1;

            Console.WriteLine("Hello! Enter your name:");

            string myName = Console.ReadLine();

            Console.WriteLine("Hello! Enter your age:");

            double myAge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hello! Enter your address:");

            string myAddress = Console.ReadLine();

            Console.WriteLine("Hello " + myName + " . " + " you are " + myAge + " years old. " + "and you live at " + myAddress);
            Console.WriteLine(mynumber);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(mynumber + myDoubleNum);
            Console.WriteLine(myDoubleNum / mynumber);

            //Assignment 1-2
            int priceOfFries = 2;
            float priceOfBurger = 5;
            double priceOfDrink = 2;
            decimal burgerDeluxe = 6.99m;

            int leastExpensiveItem = (int)Math.Min(priceOfFries, priceOfBurger);
            int mostExpensiveItem = (int)Math.Min(priceOfDrink, priceOfBurger);


            Console.WriteLine(mostExpensiveItem);
            Console.WriteLine(leastExpensiveItem);

            //Assignment 1-3,4
            int newNumber;
            int otherNewNumber;

            Console.WriteLine("Give me a number:");
            newNumber=Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Give me another number:");
            otherNewNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The total of these numbers equals: " + (newNumber+otherNewNumber) );
            Console.WriteLine("If you divide these two numbers you get: " + (newNumber+ otherNewNumber) );
        }
    }
}
