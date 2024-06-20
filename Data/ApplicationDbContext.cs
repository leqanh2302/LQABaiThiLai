using Microsoft.EntityFrameworkCore;
using LQABaiThiLai.Models;

namespace LQABaiThiLai.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<LQABaiThiLai.Models.Student> Student { get; set; } = default!;
    }
}