using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concrete
{
    internal class SalesManager : ISalesService
    {
        private IGameService gameService;
        private ICampaignService campaignService;
        public SalesManager(IGameService gameService, ICampaignService campaignService)
        {
            this.gameService = gameService;
            this.campaignService = campaignService;
        }
        public void Sales(Game game, Gamer gamer, Campaign campaign)
        {
            gamer.myGameList.Add(game);
            gameService.Delete(game);
            campaignService.Apply(campaign, game);
            Console.WriteLine(game.Name + " purchased for " + game.Price + "$");
        }
    }
}
