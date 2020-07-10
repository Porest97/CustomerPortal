using CustomerPortal.Models.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Data
{
    public class CustomerPortalContext : IdentityDbContext<ApplicationUser>
    {
        public CustomerPortalContext(DbContextOptions<CustomerPortalContext> options)
            : base(options)
        {
        }      


    }
}
