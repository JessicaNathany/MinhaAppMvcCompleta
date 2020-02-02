using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppCore.ViewModels;

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
