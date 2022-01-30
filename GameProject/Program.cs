// See https://aka.ms/new-console-template for more information
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.ServiceAdapters;




Gamer gamer1 = new Gamer { DateOfBirth = new DateTime(1996, 10, 19), FirstName = "Furkan", LastName = "Çetin", NationalityId = "14074109118" };
IGamerService gamerManager = new GamerManager(new MernisServiceAdapter());
gamerManager.Save(gamer1);

Game game1 = new Game { Name = "Forza Horizon 5", Price = 55.5M, GameType = "Race" };

Campaing campaing1 = new Campaing { CampaingName = "%50 indirim" };


ISalesService sales1 = new SalesManager();
sales1.Sell(gamer1,game1,campaing1);