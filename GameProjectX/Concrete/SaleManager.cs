using GameProjectX.Abstract;
using GameProjectX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("The gamer {0} {1} bought the game at the {2} campaing sale with {3}% discount.",gamer.FirstName, gamer.LastName,campaign.Name,campaign.Discount);
        }
    }
}
