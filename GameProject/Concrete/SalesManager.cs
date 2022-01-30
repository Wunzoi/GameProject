using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Game game, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName+ " " +gamer.LastName+ " " + campaing.CampaingName+ " kampanyası ile "+ game.Name+ " adlı oyunu satın aldı.");
        }
    }
}
