using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Delete(Campaign campaign);
        public void Update(Campaign campaign);


    }
}
