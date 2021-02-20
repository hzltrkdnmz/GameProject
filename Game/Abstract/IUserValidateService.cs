using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IUserValidateService
    {
        bool Validate(Gamer gamer);
    }
}
