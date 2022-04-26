using GameDemo.Concrete;
using GameDemo.Entities.Concrete;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Update(new Gamer { Id = 1, FirstName = "Yusuf", LastName = "Yıldız", Email = "yusuf@gmail.com", NationalityId = "23044374142", DateOfBirth = new DateTime(2000, 05, 06) });

      
            SalesManager salesManager = new SalesManager();
            salesManager.Buy(new Gamer { Id = 1, FirstName = "Yusuf", LastName = "Yıldız", Email = "yusuf@gmail.com", NationalityId = "23044374142", DateOfBirth = new DateTime(2000, 05, 06) }, new Game { Category = "Korku", Name = "Outlast2", Id = 1, Price = 10 });
            salesManager.Buy(new Gamer { Id = 1, FirstName = "Yusuf", LastName = "Yıldız", Email = "yusuf@gmail.com", NationalityId = "23044374142", DateOfBirth = new DateTime(2000, 05, 06) }, new Game { Category = "Korku", Name = "Outlast2", Id = 1, Price = 10 }, new Campaign { Id = 3, Discount = "%55", Name = "Yaz fırsatı" });

            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Emre";
            gamer.LastName = "Kızıl";
            gamer.NationalityId = "12312312312";
            gamer.DateOfBirth = new DateTime(2000, 05, 06);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Game game = new Game();
            game.Id = 1;
            game.Category = "Yarış";
            game.Name = "Forza Horizon 5";
            game.Price = 99;
            
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);


            Campaign campaign = new Campaign();
            campaign.Id = 2;
            campaign.Name = "Kış indirimi";
            campaign.Discount = "%60";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Update(campaign);

            salesManager.Buy(gamer, game);
            salesManager.Buy(gamer, game, campaign);

        }
    }
}
