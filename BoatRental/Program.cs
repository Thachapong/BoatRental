using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Boat Rental");
            Console.WriteLine("Please enter number: ");
            AmountOfBoatRental();
        }

        public static void AmountOfBoatRental()
        {
           int[] tiny = {5, 5};
           int[] medium = {10, 8};
           int[] large = {15, 12};
           int userInput = Convert.ToInt32(Console.ReadLine());

           if (userInput > (int) tiny.GetValue(1) && (userInput >= (int)medium.GetValue(1) && userInput <= (((int)medium.GetValue(1)) * 2)))
           {
               Console.WriteLine("Medium =" + 2 + "," + "Cost = " + ((int)medium.GetValue(1) * 2) + "$");
           }
           else if (userInput > ((int)medium.GetValue(1)*2) && userInput <= ((int)large.GetValue(1) * 2))
           {
               Console.WriteLine("Large =" + 1 + " Medium =" + 1 + "," + "Cost = " + ((int)medium.GetValue(1) + (int)large.GetValue(1)) + "$");
           }
           else if (userInput > ((int) large.GetValue(1) * 2))
           {
               Console.WriteLine("Large =" + 2 + " Medium =" + 1 + "," + "Cost = " + ((int)medium.GetValue(1) + ((int)large.GetValue(1)*2)) + "$");
           }
           else
           {
               Console.WriteLine("Tiny ="+ 1 +","+"Cost = " + (int)tiny.GetValue(1)+"$");
           }
           Console.ReadLine();
        }
    }
}
