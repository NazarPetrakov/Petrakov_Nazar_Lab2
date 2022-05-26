using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratorna2
{
    class Program
    {
        static void Main(string[] args)
        {
            char result = ' ';
            byte number = 0;
            Computer comp = new Computer(
                new HDD(500, "Western Digital blue"),
                new Drive(2, "DVD-RW ASUS DRW-24D5MT"),
                new RAM(16, "Kingston DDR3-1600"),
                new CPU(2.9, "Intel Core i5-10400")
           );
            while (comp.isTurnOn == false)
            { 
                Console.WriteLine("Ви бажаєте включити комп'ютер? (+/-)");
           
                result = Console.ReadLine()[0];
                if (result == '+')
                {

                    Console.WriteLine(comp.Loading());
                    Console.WriteLine(comp.TurnON());
                    while (comp.isTurnOn)
                    {
                        Console.WriteLine("Виберiть наступну дiю" +
                            "\n1 - Перевiрити комп'ютер на вiруси" +
                            "\n2 - Вивести на консоль розмiр вiнчестера" +
                            "\n3 - Виключити комп'ютер" +
                            "\n4 - Слава Українi!");
                        Console.WriteLine("=====");
                        number = Byte.Parse(Console.ReadLine());
                        Console.WriteLine("=====");
                        
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine(comp.Loading());
                                Console.WriteLine("Перевiрка на вiруси закiнчена");
                                Console.WriteLine(comp.VirusScan());
                                break;
                            case 2:
                                Console.WriteLine(comp.hdd);
                                break;
                            case 3:
                                Console.WriteLine(comp.TurnOFF());
                                break;
                            case 4:
                                Console.WriteLine("Героям Слава!\n");
                                break;

                            default:
                                Console.WriteLine("Введiть цифру вiд 1 до 3");
                                Console.Read();
                                System.Environment.Exit(1);
                                break;

                        }
                    }
                }
                else
                {
                    Console.WriteLine(comp.TurnOFF());
                }

                }

            Console.ReadLine();

        }
    }
}
