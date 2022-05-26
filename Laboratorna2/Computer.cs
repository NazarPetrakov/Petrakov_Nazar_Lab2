using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Laboratorna2
{
    class Computer
    {
        public bool isTurnOn = false;
        public HDD hdd;
        private Drive drive;
        private RAM ram;
        private CPU cpu;

        public string TurnON()
        {
            isTurnOn = true;
            return "Комп'ютер включений\n";
        }
        public string TurnOFF()
        {
            isTurnOn = false;
            return "Комп'ютер виключений\n";
        }
        public string VirusScan()
        {
            Random rand = new Random();
            int numb = rand.Next(0, 10);
            switch (numb)
            {
                case 0:
                    return "На вашому комп'ютерi немає вiрусiв\n";
                    break;
                case 1:
                    return "На вашому комп'ютерi " + numb + " вiрус\n";
                    break;
                case int n when(n>1 && n<5):
                    return "На вашому комп'ютерi " + numb + " вiруса\n";
                    break;
                
                case int n when (n > 4 && n < 11):
                    return "На вашому комп'ютерi " + numb + " вiрусiв\n";
                    break;
                          

            }
            return " ";
        }
        public string Loading()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(700);
                
            }
            return "\n";
        }

        public Computer(HDD hdd, Drive drive, RAM ram, CPU cpu )
        {
            this.hdd = hdd;
            this.drive = drive;
            this.ram = ram;
            this.cpu = cpu;

        }

    }   
    class HDD
    {
        private int memory;
        private string name;
        public HDD(int mem, string name)
        {
            this.memory = mem;
            this.name = name;
        }
       
        public override string ToString()
        {
            return "Розмiр вiнчестера " + memory + " гб\n"; ;
        }
    }
    class Drive
    {
        private int count;
        private string name;
        public Drive(int drive, string name)
        {
            this.count = drive;
            this.name = name;
        }
    }
    class RAM
    {
        private int ram;
        private string name;
        public RAM(int ram, string name)
        {
            this.ram = ram;
            this.name = name;
        }
    }
    class CPU
    {
        private double cpu;
        private string name;
        public CPU(double cpu, string name)
        {
            this.cpu = cpu;
            this.name = name;

        }
    }
}
