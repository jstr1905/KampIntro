using GameDemo.Abstract;
using GameDemo.Entities.Abstract;
using GameDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class GamerManager
    {
        private IGamerCheckService gamerCheckService;
        

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            this.gamerCheckService = gamerCheckService;
        }

        public void Register(Gamer gamer)
        {
            if (gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Kullanıcı kayıt oldu : " + gamer.Email + " " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                throw new Exception("Gerçek kimlik ile giriş yapınız");
            }

        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı kaydı silindi : " + gamer.Email + " " + gamer.FirstName + " " + gamer.LastName);
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı bilgileri güncellendi : " + gamer.Email + " " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
