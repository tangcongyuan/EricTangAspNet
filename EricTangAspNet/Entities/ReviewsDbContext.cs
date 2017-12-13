using Microsoft.EntityFrameworkCore;

namespace EricTangAspNet.Entities
{
    public class ReviewsDbContext: DbContext
    {
        public ReviewsDbContext(DbContextOptions<ReviewsDbContext> options) : base(options) { }

        public DbSet<Review> Reviews { get; set; }
    }
}
