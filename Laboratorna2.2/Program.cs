using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Person Ben = new Person(new MainJob(13000), new SecondJob(8000), new AutorReward(2000), new Sale(5000), new Gift(400), new Abroad(10000), new Privilegia(0));
            double[] sortPodatok = { Ben.GetMainPodatok(), Ben.GetSecondPodatok(), Ben.GetRewardPodatok(), Ben.GetSalePodatok(), Ben.GetGiftPodatok(), Ben.GetAbroadPodatok(), Ben.GetPrivilegiaPodatok()};
            Array.Sort(sortPodatok);
            Console.WriteLine($"Кiлькiсть податкових виплат: {sortPodatok.Length}");
            for (int i = 0; i < sortPodatok.Length; i++)
            {
                Console.WriteLine(sortPodatok[i]);
                sum += sortPodatok[i];

            }
            Console.WriteLine($"Загальна сума податкових виплат: {sum}");
            Console.ReadLine();
        }
    }
}
