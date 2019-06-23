using StudentFinder.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentFinder.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<StudentsModel> StudentsModel { get; set; }
  }
}