using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities.Abstract
{
    interface IGameService
    {
        public void Add(Game game);
        public void Update(Game game);
        public void Delete(Game game);
    }
}
