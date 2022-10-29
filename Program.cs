using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_TRAIDING_coumpund_prodit_calculator
{
  public class Program
    {
      
        

        public static void persentage_going_up_calculate(double price,double persentage_going_up)
        {
            price = price * persentage_going_up/100; 
        }
        public static void persentage_going_down_calculate()
        {

        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("how many trades are you going to make?");

        int Amount_of_trades =int.Parse( Console.ReadLine());
            for (int i = 1; i <= Amount_of_trades; i++)
            {
                Console.WriteLine("PLEASE chose how if price goes down or up");
                Console.WriteLine("1.Price goes up");
                Console.WriteLine("2.Price goes down");
            int    choice = int.Parse(Console.ReadLine());
                if (choice==1)
                {
                    Console.WriteLine("please type  price of cryptocurrency");
                  double  cryptoPrice =double.Parse( Console.ReadLine());
                  
                    Console.WriteLine("please type the persentage it goes up");
                 int   persentage_going_up_calculate =int.Parse( Console.ReadLine());
                    double   value =cryptoPrice *persentage_going_up_calculate /100;
                    cryptoPrice= cryptoPrice + value;
                    Console.WriteLine(" price after calculation "+i+": "+ cryptoPrice);
                    Console.WriteLine();

                }
                else if (choice==2)
                
                {
                    Console.WriteLine("please type  price of cryptocurrency");
                    double cryptoPrice = double.Parse(Console.ReadLine());
                    Console.WriteLine("please type the persentage it goes down");
                    int persentage_going_up_calculate = int.Parse(Console.ReadLine());
                    double value = cryptoPrice * persentage_going_up_calculate / 100;
                    cryptoPrice = cryptoPrice - value;
                    Console.WriteLine(" price after calculation " + i + ": " + cryptoPrice);
                }

            }

        }
    }
}
