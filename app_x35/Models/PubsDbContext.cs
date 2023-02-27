using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Cps_x35.Models
{
    public class PubsDbContext : DbContext
    {
        public String GetMySqlConnStr(string fileName)
        {
            // Now we can read the serialized book ...  
            var myJsonString = File.ReadAllText(fileName);
            CpsConfig config = JsonSerializer.Deserialize<CpsConfig>(myJsonString);

            return config.MysqlOracle.ConnectionString;
        }
        /// <summary>
        /// ASP.NET CORE and normal Dotnet
        /// <see cref="OnConfiguring" href="https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/#simple-dbcontext-initialization-with-new" langword="DbContext instances can be constructed in the normal .NET way" />
        /// <list type="bullet">
        /// <item>
        /// <description>Name</description>
        /// <description>Method</description>
        /// </item>
        /// <item>
        /// <description>Pomelo</description>
        /// <description>=> optionsBuilder.UseMySql("connection string", "mysql version");</description>
        /// </item>
        /// <item>
        /// <description>MySql.EntityFrameworkCore</description>
        /// <description>=> optionsBuilder.UseMySQL("connection string");</description>
        /// </item>
        /// </list>
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(
                GetMySqlConnStr("cpsConfig.json"),
                new MySqlServerVersion(new Version(8, 0, 32))
                ); // Pomelo.EntityFrameworkCore.MySql

        public DbSet<ArriveStation> ArriveStations { get; set; }
        public DbSet<BreedCoal> BreedCoals { get; set; }
        public DbSet<DispatchStore> DispatchStores { get; set;  }
        public DbSet<LotNumber> LotNumbers { get; set; }
        public DbSet<WeightStation> WeightStations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DispatchStore>().HasKey(ds => new { ds.CarNumber, ds.LotNumberId });
        }
    }
}
