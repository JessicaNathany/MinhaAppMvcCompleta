using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevApp.Data
{
    public class MvcCompletaDbContext : IdentityDbContext
    {
        public MvcCompletaDbContext(DbContextOptions<MvcCompletaDbContext> options)
            : base(options)
        {
        }
    }
}
