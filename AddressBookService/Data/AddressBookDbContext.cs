using AddressBookService.Model.Database;
using Microsoft.EntityFrameworkCore;

namespace AddressBookService.Data
{
    public class AddressBookDbContext : DbContext
    {
        public AddressBookDbContext() {}

        public AddressBookDbContext(DbContextOptions<AddressBookDbContext> options)
            : base(options) {}

        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressBook> AddressBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressBook>()
                .HasOne(ab => ab.Address)
                .WithOne(a => a.AddressBook)
                .HasForeignKey<Address>(a => a.AddressBookId);
        }
    }
}
