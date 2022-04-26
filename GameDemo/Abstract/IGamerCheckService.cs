using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer);

    }
}
