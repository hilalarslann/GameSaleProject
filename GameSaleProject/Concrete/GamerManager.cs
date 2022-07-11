using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concrete
{
    internal class GamerManager : IGamerService
    {
        private IUserValidationService userValidationService;

        List<Gamer> gamerList = new List<Gamer>();

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }
        public void Save(Gamer gamer)
        {
            if (userValidationService.Validation(gamer))
            {
                gamerList.Add(gamer);
                Console.WriteLine("Authenticated, record added");
            }
            else
            {
                Console.WriteLine("not authenticated, no record added");
            }
        }

        public void Delete(Gamer gamer)
        {
            gamerList.Remove(gamer);
        }

        public void Update(Gamer gamer)
        {
            int gamerIndex = gamerList.IndexOf(gamer);
            gamerList[gamerIndex] = gamer;
        }
    }
}
