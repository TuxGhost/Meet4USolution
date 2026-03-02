using dit.database.net;
using dit.database.net.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace TestProject_Databases
{
    [TestClass]
    public class DitDatabaseTest
    {
        DitDbContext dbContext = null!;
        IConfigurationRoot config = null!;
        [TestInitialize] 
        public void Init() 
        {
            config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            var options = new DbContextOptionsBuilder<DitDbContext>()
                //.UseMySQL("server=localhost;user=db_admin;password=-l7Shq3ZrrQBEDkq;database=dit_jag;ConvertZeroDatetime=true;AllowZeroDateTime=true");
                .UseMySQL("server=localhost;Database=wp;User=root;Password=Continuum23!;ConvertZeroDatetime=true;AllowZeroDateTime=true;");
                //.UseMySQL(connectionString);

            dbContext = new DitDbContext(options.Options);
        }
        [TestMethod]
        public void ClubUsersReadAllDataFromDatabase()
        {                        
            List<ModClubUser>  users = dbContext.ModClubUsers.ToList();
        }
        [TestMethod]
        public void ClubUserReadId31_Existing()
        {
            ModClubUser? user = dbContext.ModClubUsers.SingleOrDefault(x => x.Id == 31);
            Assert.IsNotNull(user);
        }
        [TestMethod]
        public void ClubUserReadId30_NonExisting()
        {
            ModClubUser? user = dbContext.ModClubUsers.SingleOrDefault(x => x.Id == 30);
            Assert.IsNull(user);
        }
    }
}