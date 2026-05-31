using Microsoft.EntityFrameworkCore;

namespace GovernanceTechShowcase.EfCore
{
    public class OperationalRecord
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAtUtc { get; set; }
    }

    public class ShowcaseDbContext : DbContext
    {
        public DbSet<OperationalRecord> OperationalRecords => Set<OperationalRecord>();
    }
}
