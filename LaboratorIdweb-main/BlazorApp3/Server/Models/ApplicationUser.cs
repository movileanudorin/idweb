using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BlazorApp3.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; }

        public List<Wallet> Wallets { get; set; }
    }
}
