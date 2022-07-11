using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject.Abstracts
{
    internal interface IGameService
    {
        void Save(Game game);
        void Delete(Game game);
    }
}
