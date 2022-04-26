using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface ISalesService
    {
        public void Buy(Gamer gamer,Game game);
        public void Buy(Gamer gamer, Game game,Campaign campaign);
        
    }
}
