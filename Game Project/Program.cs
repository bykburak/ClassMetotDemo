using System;

namespace GameProjectOOPOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {
                Id = 1,
                FirstName = "BURAK",
                LastName = "BÜYÜKKARA",
                BirthYear = 1992,
                IdentityNumber = 12345

            });

            GamgeManager gameManager = new GamgeManager();
            gameManager.Add(new Game {
                Id = 1,
                GameName = "Valorant"
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {
                Id = 1,
                CampaingName = "Black Friday",
                CampaignDiscountRate = 10                
            });

            

            OrderManager orderManager = new OrderManager();
            orderManager.Add(new Order
            {
                Id = 1,
                OrderPrice = 20,
                GameId = 1
            });

            

        }
    }
}
