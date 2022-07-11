using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Concrete
{
    internal class GameManager : IGameService
    {
        public List<Game> gameList = new List<Game>();
        public void Delete(Game game)
        {
            gameList.Remove(game);
        }

        public void Save(Game game)
        {
            gameList.Add(game);
        }
    }
}
