using GameProjectX.Concrete;
using GameProjectX.Entities;
using System;

namespace GameProjectX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test
            Gamer gamer1 = new Gamer()
            {
                GamerId = 1,
                BirthYear = 1997,
                FirstName = "İremm",
                LastName = "Çalışkan",
                IdentityNumber = 12345678912
            };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1); // Hata

            GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager2.Add(gamer1);

            Campaign campaign = new Campaign()
            {
                CampaignId = 1,
                Name = "Black Friday",
                Discount = 50
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1,campaign);
        }
    }
}
