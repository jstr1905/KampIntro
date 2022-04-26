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
            Console.WriteLine("Oyun silindi");
        }

        public void Add(Game game)
        {
            Console.WriteLine("Yeni oyun eklendi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi");
        }
    }
}
