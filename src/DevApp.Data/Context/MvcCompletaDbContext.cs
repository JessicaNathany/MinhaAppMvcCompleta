using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;
using Microsoft.EntityFrameworkCore;



namespace DevApp.Data.Context
{
    public class MvcCompletaDbContext : DbContext
    {
        public MvcCompletaDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Produto> Produtos { get; set; }

        DbSet<Endereco> Endereços { get; set; }
        
        DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             modelBuilder.ApplyConfigurationsFromAssembly(typeof(MvcCompletaDbContext).Assembly);

            

            //foreach(var relationship in modelBuilder.Model.GetEntityTypes.().SelectMany(async=))

            base.OnModelCreating(modelBuilder);
        }
    }
}
