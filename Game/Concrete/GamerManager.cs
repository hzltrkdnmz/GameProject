using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class GamerManager : IGamerService
    {
        public IUserValidateService _userValidateService;
        public GamerManager(IUserValidateService userValidateService)
        {
            _userValidateService = userValidateService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidateService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu eklendi.");
            }
            else
            {
                throw new Exception("Eklenemedi");
            }
          
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu silindi.");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu güncellendi.");
        }

        public bool Validate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
