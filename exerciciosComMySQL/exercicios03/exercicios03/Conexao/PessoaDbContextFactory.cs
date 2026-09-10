using exercicios03.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class PessoaDbContextFactory : IDesignTimeDbContextFactory<PessoaDbContext>
{

    private readonly string _server = "localhost";          
    private readonly string _database = "base_ef";          
    private readonly string _user = "root";                 
    private readonly string _password = "Jaquelinemorais2004@";         

   
    public PessoaDbContext CreateDbContext(string[] args)
    {
        
        var connectionString = $"Server={_server};Database={_database};User={_user};Password={_password};";

        var optionsBuilder = new DbContextOptionsBuilder<PessoaDbContext>();
        optionsBuilder.UseMySQL(connectionString);

        return new PessoaDbContext(optionsBuilder.Options);
    }
}