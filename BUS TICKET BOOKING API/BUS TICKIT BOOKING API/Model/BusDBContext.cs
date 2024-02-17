using Microsoft.EntityFrameworkCore;

namespace BUS_TICKIT_BOOKING_API.Model
{
    public class BusDBContext:DbContext
    {
        public BusDBContext(DbContextOptions<BusDBContext> options):base(options)
        {
            
        }
        public DbSet<BUS> bustickitbooking {  get; set; }
    }
}
