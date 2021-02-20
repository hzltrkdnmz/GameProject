using Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Abstract
{
    public interface IGameService
    {
        void Add(GameProduct game);
        void Delete(GameProduct game);
        void Update(GameProduct game);
    }
}
