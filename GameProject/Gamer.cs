using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOOPOdev
{
    class Gamer
    {
        public int Id{ get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int BirthYear { get; set; }

        public long IdentityNumber { get; set; } //mernis doğrulama servisinden long geliyor çünkü tc no

    }
}
