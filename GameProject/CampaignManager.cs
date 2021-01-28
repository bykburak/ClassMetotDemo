using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOPOdev
{
    class CampaignManager : ICampaignManager
    {


       

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde eklendi: " + campaign.CampaingName);
        }

        

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde silindi: " + campaign.CampaingName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya başarılı bir şekilde güncelledi: " + campaign.CampaingName);
        }

        
    }
}
