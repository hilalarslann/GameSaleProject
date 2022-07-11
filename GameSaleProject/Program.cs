using GameSaleProject.Concrete;
using GameSaleProject.Entities;
using System;

namespace GameSaleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            SalesManager salesManager = new SalesManager(new GameManager(), new CampaignManager());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();

            Gamer gamer = new Gamer() { NationalityId = 45986348777, FirstName = "Hilal", LastName = "Arslan", DateYear = 1997  };
            gamerManager.Save(gamer);

            Game game = new Game() { Id = 1, Name = "Spin Rush", Price = 100 };
            gameManager.Save(game);

            Campaign campaign = new Campaign() { Id = 1, CampaignName = "FiftyPercentDiscount" };

            campaignManager.Save(campaign);

            salesManager.Sales(game, gamer, campaign);

            Console.ReadLine();
        }
    }
}
