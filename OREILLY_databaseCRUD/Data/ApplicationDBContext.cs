using Microsoft.EntityFrameworkCore;
using OREILLY_databaseCRUD.Models;
namespace OREILLY_databaseCRUD.Data
{
    public class ApplicationDBContext : DbContext
    {
      //  private IConfiguration Configuration { get; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }
     
   // 数据库操作的主要方法
        public DbSet<Category> Categories { get; set; }

    }
}