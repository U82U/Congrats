using System.Data.Entity;
using Congrats.Domain.Members;

namespace Congrats.Daab
{
    internal class EFDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}
