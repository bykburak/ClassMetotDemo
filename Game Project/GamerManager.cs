using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOPOdev
{
    class GamerManager : IGamerService
    {

        IUserValidationService _userValidationService;
        private object userValidationService1;

        public GamerManager (IUserValidationService userValidationService)
        {
            _userValidationService =  userValidationService;
        }

        public GamerManager(IUserValidationService userValidationService, object userValidationService1) : this(userValidationService)
        {
            this.userValidationService1 = userValidationService1;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) ==  true)
            {

                Console.WriteLine("Oyuncu başarılı bir şekilde eklendi: " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi. TCKN doğrulama yapılamadı: " + gamer.FirstName +  " " + gamer.LastName);
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi: " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi: " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
