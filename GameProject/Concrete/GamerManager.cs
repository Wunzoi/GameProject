using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " veritabanından silindi.");
        }

        public void Save(Gamer gamer)
        {
            if (_gamerCheckService.IsGamerRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " veritabanına kaydedildi.");
            }
            else
            {
                throw new Exception("Böyle bir kişi mevcut değil.");
            }
            
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " veritabanında güncellendi.");
        }
    }
}
