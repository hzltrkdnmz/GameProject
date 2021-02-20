using Game.Concrete;
using Game.Entities;
using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {BirthYear = 1994, FirstName = "Hazel",LastName = "Türkdönmez" };
            GameProduct game = new GameProduct() { GameName = "Game1", GamePrice = 100 };
            GamerManager gamerManager = new GamerManager(new UserValidateManager());
            GameManager gameManager = new GameManager();
            gamerManager.Add(gamer);
            gameManager.Add(game);


            SalesManager sales = new SalesManager(gamer, game);
            sales.Sales(gamer, game);
          

            
        }
    }
}
