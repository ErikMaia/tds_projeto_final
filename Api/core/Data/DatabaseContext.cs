using api.core.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
public class DatabaseContext : DbContext
{
    public DbSet<MaterialModel>? Material { get; set; }
    public DbSet<QuizzModel>? Quiz { get; set; }
    public DbSet<StudentModel>? Student { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 31)); // Especifique a versão correta do servidor MySQL aqui

        optionsBuilder.UseMySql("Server=database;Port=3306;Database=tarefas;User=root;Password=tarefas;",
            serverVersion,
            options => options.EnableRetryOnFailure()
        );
    }
}
