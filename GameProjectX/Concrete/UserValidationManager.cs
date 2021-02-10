using GameProjectX.Abstract;
using GameProjectX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1997 && 
                gamer.FirstName == "İrem" && 
                gamer.LastName == "Çalışkan" &&
                gamer.IdentityNumber == 12345678912)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
