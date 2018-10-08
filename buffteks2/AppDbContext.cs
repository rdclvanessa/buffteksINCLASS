using System; 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace buffteks2
{
    //here we extend the DbContext class without own class 'AppDbContext'
    public class AppDbContext : DbContext
    {
        //the connection string is used by the SQL Server database provider to find the database
        private const string ConnectionString = @"Data Source=MyFirstEFCore.db";


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            //Using the SQLite database provider's UseSqlServer command sets up the options ready for creating
            optionsBuilder.UseSqlite(ConnectionString); //#8
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamProject> TeamProjects { get; set; }



    }
}