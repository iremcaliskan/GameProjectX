using GameProjectX.Abstract;
using GameProjectX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Concrete
{
    class NewEStateUserValidationManager : IUserValidationService
    { // Yeni bir e doğrulama istensin, yeni bir mikro servis
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
