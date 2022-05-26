using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorna2._2
{
    class Person
    {
        public MainJob mainJob;
        public SecondJob secondJob;
        public AutorReward autorReward;
        public Sale sale;
        public Gift gift;
        public Abroad abroad;
        public Privilegia privilegia;


        public Person(MainJob mainJob, SecondJob secondJob, AutorReward autorReward, Sale sale, Gift gift, Abroad abroad, Privilegia privilegia)
        {
            this.mainJob = mainJob;
            this.secondJob = secondJob;
            this.autorReward = autorReward;
            this.sale = sale;
            this.gift = gift;
            this.abroad = abroad;
            this.privilegia = privilegia;
        }
        public double GetMainPodatok()
        {
            return mainJob.mainJob * 20 / 100;
        }
        public double GetSecondPodatok()
        {
            return secondJob.secondJob * 20 / 100;
        }
        public double GetRewardPodatok()
        {
            return autorReward.autorReward * 20 / 100;
        }
        public double GetSalePodatok()
        {
            return sale.sale * 1 / 100;
        }
        public double GetGiftPodatok()
        {
            if(gift.gift < 1500)
            {
                return 0;
            }
            return gift.gift * 18 / 100;
        }
        public double GetAbroadPodatok()
        {
            return abroad.abroad * 18 / 100;
        }
        public double GetPrivilegiaPodatok()
        {
            return privilegia.privilegia * 18 / 100;
        }

    }
    class MainJob
    {
        public MainJob(int mainJob)
        {
            this.mainJob = mainJob;
            
        }
        public int mainJob;
       
        
    }
}
class SecondJob
{
    public SecondJob(int secondJob)
    {
        this.secondJob = secondJob;
        
    }
    public int secondJob;
   
    
}
class Sale
{
    public Sale(int sale)
    {
        this.sale = sale;
       
    }
    public int sale;
    

}
class AutorReward
{
    public AutorReward(int autorReward)
    {
        this.autorReward = autorReward;
       
    }
    public int autorReward;
    

}
class Gift
{
    public Gift(int gift)
    {
        this.gift = gift;
       
    }
    public int gift;
   

}
class Abroad
{
    public Abroad(int abroad)
    {
        this.abroad = abroad;

    }
    public int abroad;


}
class Privilegia
{
    public Privilegia(int privilegia)
    {
        this.privilegia = privilegia;

    }
    public int privilegia;


}

