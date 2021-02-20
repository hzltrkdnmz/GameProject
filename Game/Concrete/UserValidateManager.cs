using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class UserValidateManager : IUserValidateService
    {
      public bool Validate(Gamer gamer)
       {
                 if (gamer.BirthYear == 1994 && gamer.FirstName == "Hazel"
                    && gamer.LastName == "Türkdönmez")
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
