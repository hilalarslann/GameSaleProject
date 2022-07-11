using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Entities
{
    internal class Gamer : User
    {
        public List<Game> myGameList = new List<Game>();
    }
}
