using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, GameProduct game);
        void SalesWithCampaign(Gamer gamer, GameProduct game, Campaign campaign);
    }
}
