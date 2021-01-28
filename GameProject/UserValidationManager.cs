using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOPOdev
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer) ////return ettiğimiz için true ya da false döndürüyoruz.
        {
            if (gamer.FirstName == "BURAK" && gamer.BirthYear > 1985) // mernis servisinden gelen datalar ile doğrulama similasyonu yapıyoruz..
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    
    }
}
