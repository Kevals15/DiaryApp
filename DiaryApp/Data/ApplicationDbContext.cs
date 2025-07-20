using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Dummy title 1",
                    Content = "Hello Dummy content 1",
                    CreatedAt = new DateTime(2025,07,20,15,22,30)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Dummy title 2",
                    Content = "Hello Dummy content 2",
                    CreatedAt = new DateTime(2025, 07, 20, 15, 23, 30)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Dummy title 3",
                    Content = "Hello Dummy Content 3",
                    CreatedAt = new DateTime(2025, 07, 20, 15, 24, 30)
                });
        }

        //Four steps to add Table 
        // 1) create Model
        // 2) Add Db Set
        // 3) add-migration AddDiaryEntryTable
        // 4) update-database
    }
}
