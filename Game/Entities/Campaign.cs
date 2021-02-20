using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Entities
{
   public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaingName { get; set; }
        public int DiscountRate { get; set; }
    }
}
