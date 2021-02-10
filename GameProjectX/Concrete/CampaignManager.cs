using GameProjectX.Abstract;
using GameProjectX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("New {1}% discount {0} campaign is added!", campaign.Name,campaign.Discount);        
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("The {1}% discount {0} campaign is deleted!", campaign.Name, campaign.Discount);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The {1}% discount {0} campaign is updated!", campaign.Name, campaign.Discount);
        }
    }
}
