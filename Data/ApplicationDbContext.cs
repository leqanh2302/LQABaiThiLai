using Microsoft.EntityFrameworkCore;

namespace LQA_BaiThi_2324.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    }
}