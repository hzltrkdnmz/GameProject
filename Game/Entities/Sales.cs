using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
    public class Sales:IEntity
    {
        public int SalesId { get; set; }
        public float SalesPrice { get; set; }
        public DateTime SalesDate { get; set; }
    }
}
