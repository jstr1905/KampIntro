using GameDemo.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class SalesManager : ISalesService

    {
        public void Buy(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.Name + " oyununu satın aldı");
        }

        public void Buy(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.Name + " oyununu " + campaign.Discount + " " + "indirimle satın aldı");
        }
    }
}
