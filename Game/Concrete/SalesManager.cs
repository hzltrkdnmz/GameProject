using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    class SalesManager : ISalesService
    {
        private Gamer gamer;
        private GameProduct game;

        public SalesManager(Gamer gamer, GameProduct game)
        {
            this.gamer = gamer;
            this.game = game;
        }

        public void Sales(Gamer gamer, GameProduct game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu " + game.GameName + " oyununu satın aldı.");
        }

        public void SalesWithCampaign(Gamer gamer, GameProduct game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " oyuncusu " + game.GameName + " oyununu " + campaign.DiscountRate + " indirimle satın aldı.");
        }
    }
}
