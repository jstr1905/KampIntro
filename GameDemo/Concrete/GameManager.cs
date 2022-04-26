using GameDemo.Entities.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class GameManager : IGameService

    {
        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi" + " " + game.Name);
        }

        public void Add(Game game)
        {
            Console.WriteLine("Yeni oyun eklendi" + " " + game.Name + " " + game.Price + " TL");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi" + " " + game.Name);
        }
    }
}
