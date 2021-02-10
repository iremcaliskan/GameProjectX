using GameProjectX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);

    }
}
