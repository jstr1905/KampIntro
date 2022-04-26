using GameDemo.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class CampaignManager : ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi "+ campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi " + campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi " + campaign.Name);
        }
    }
}
