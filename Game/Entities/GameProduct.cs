using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class GameProduct:IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public float GamePrice { get; set; }
    }
}
