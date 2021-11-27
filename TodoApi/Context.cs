using Microsoft.EntityFrameworkCore;
using TodoApi.Model;

namespace TodoApi
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Info> Info { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Info>()
                .HasData(
                    new Info { Id = 1, Nome = "Arthur", Senha = "123456", Email = "aa@aa", CPF = "123.123.123-12", Contato = "3123123123" },
                    new Info { Id = 2, Nome = "Claudio", Senha = "654321", Email = "bb@bb", CPF = "321.321.321-21", Contato = "1231213" }
                );
        }
    }
}