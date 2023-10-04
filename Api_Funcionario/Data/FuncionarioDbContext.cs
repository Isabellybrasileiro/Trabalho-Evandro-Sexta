using Api_Funcionario.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Funcionario.Data;
public class FuncionarioDbContext : DbContext
{
    public DbSet<Funcionario>? Funcionario { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=funcionario.db;Cache=Shared");
    }

}