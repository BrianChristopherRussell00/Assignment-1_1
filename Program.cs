using Microsoft.VisualBasic;

namespace Assignment_1_1
{
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

            Console.WriteLine("Hello " + myName + " . " + " you are " + myAge + " years old. " + "and you live at" + myAddress);
            Console.WriteLine(mynumber);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(mynumber+myDoubleNum);
            Console.WriteLine(myDoubleNum/mynumber);

        }
    }
}
