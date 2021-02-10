using GameProjectX.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Entities
{
    class Sale : IEntity
    {
        public int SaleId { get; set; }
        public int GamerId { get; set; }
        public int CampaignId { get; set; }
        public DateTime DateOfSale { get; set; }

    }
}
