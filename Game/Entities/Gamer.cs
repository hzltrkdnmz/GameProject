using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string GamerId { get; set; }

        public static implicit operator Gamer(GameProduct v)
        {
            throw new NotImplementedException();
        }
    }
}
