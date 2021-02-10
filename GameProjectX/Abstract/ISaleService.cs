using GameProjectX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Campaign campaign);
    }
}
