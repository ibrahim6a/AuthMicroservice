
using Microsoft.EntityFrameworkCore;

namespace AuthMicroservice.Models {
    public class AuthContext: DbContext {
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySQL("server=77.68.120.114;port=3306;database=AuthMicroservice;user=ibrahim6a;password=ibrahim6a");
    }
}