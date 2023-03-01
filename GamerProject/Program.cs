using GamerProject.Adapters;
using GamerProject.Concrete;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
  public  class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Last Of Us",
                GamePrice = 1000
            };
            Gamer gamer1 = new Gamer()
            {
                Id = 2,
                NationalityId = "17591203222",
                FirstName = "Özge",
                LastName = "bektaş",
                DateOfBirth = new DateTime(1998, 05, 10),
                UserName = "Yoda"
            };
            Campaign campaign1 = new Campaign()
            {
                CampaignName = "Special discount for this week",
                Discount = 52.25
            };
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);


            SalesManager salesManager = new SalesManager();
            salesManager.Add(game1, gamer1, campaign1);

            Console.ReadLine();

        }
    }
}
