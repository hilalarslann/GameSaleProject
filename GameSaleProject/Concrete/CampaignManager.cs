using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        List<Campaign> campaignList = new List<Campaign>();
        public void Delete(Campaign campaign)
        {
            campaignList.Remove(campaign);
        }

        public void Save(Campaign campaign)
        {
            campaignList.Add(campaign);
        }

        public void Update(Campaign campaign)
        {
            int campaignIndex = campaignList.IndexOf(campaign);
            campaignList[campaignIndex] = campaign;
        }

        public void Apply(Campaign campaign, Game game)
        {
            if (campaign.CampaignName == "FiftyPercentDiscount")
            {
                FiftyPercentDiscount(game);
            }
        }
        public void FiftyPercentDiscount(Game game)
        {
            game.Price *= 0.50;
        }
    }
}
