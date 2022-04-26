using GameDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities.Concrete
{
    public class Campaign:IEntity

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discount { get; set; }
    }
}
