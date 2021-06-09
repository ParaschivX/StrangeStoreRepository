using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public int Tokens { get; set; }
            

      //  public List Messages { get; set; }

    }
}
