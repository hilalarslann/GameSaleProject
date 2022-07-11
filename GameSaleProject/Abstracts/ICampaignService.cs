using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstracts
{
    internal interface ICampaignService
    {
        void Save(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
        void Apply(Campaign campaign, Game game);
    }
}
