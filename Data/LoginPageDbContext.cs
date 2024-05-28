using LoginPage.Models;
using Microsoft.EntityFrameworkCore;

public class LoginPageDbContext:DbContext
 {
    public DbSet<LoginModel> credentials{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string c = "Server = LIN-PF1PLC98; Database = LoginPageDb; User id = sa; Password = Prakash@3143; TrustServerCertificate = True";
        optionsBuilder.UseSqlServer(c);
    }

} 


