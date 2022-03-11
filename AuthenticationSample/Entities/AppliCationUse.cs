using Microsoft.AspNetCore.Identity;
using System;

namespace BookStore.IdentityProvider.Entities
{
    public class AppliCationUser : IdentityUser
    {
        public DateTime CompanyStarteDate { get; set; }
        [PersonalData]
        public string Address { get; set; }
    }
}
