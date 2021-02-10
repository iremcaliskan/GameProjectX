using GameProjectX.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Entities
{
    class Gamer : IEntity
    {
        public int GamerId { get; set; }
        public long IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

    }
}
