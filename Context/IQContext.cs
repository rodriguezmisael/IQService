using IQService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace IQService.Context
{
    public class IQContext :  DbContext
    {

        public IQContext(DbContextOptions<IQContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<CustomerPerson> CustomerPeople { get; set; }
        public DbSet<CustomerService> CustomerServices { get; set; }
        public DbSet<CustomerStatus> CustomerStatuses { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceStatus> ServiceStatuses { get; set; }
        public DbSet<ServiceSubType> ServiceSubTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<ServiceDate> ServiceDates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Certificate>().ToTable("Certificate");
            modelBuilder.Entity<CustomerPerson>().ToTable("CustomerPerson");

        }




    }
}
