using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class GameManager : IGameService
    {
       
        public void Add(GameProduct game)
        {
            Console.WriteLine(game.GameName + " oyunu eklendi.");
        }
        public void Delete(GameProduct game)
        {
            Console.WriteLine(game.GameName + " oyuncusu silindi.");
        }
        public void Update(GameProduct game)
        {
            Console.WriteLine(game.GameName + " oyuncusu güncellendi.");

        }
    }

}