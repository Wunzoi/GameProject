using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName+ " kampanyası eklendi.");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " kampanyası silindi.");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + " kampanyası güncellendi.");
        }
    }
}
