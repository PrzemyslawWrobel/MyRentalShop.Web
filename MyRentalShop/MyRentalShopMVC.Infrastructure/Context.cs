using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Type = MyRentalShopMVC.Domain.Model.Type;

namespace MyRentalShopMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }
        public DbSet<ContactDetailType> ContactDetailTypes { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerContactInformation> CustomerContactInformation { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentDetailType> DocumentDetailTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemTag> ItemTag { get; set; } // w liczbie poj ponieważ jest to tabela pośrednia w relacji wiele do wielu
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Type> Types { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            ///Informacja po czym Entity ma zbudować relację 1 : 1

            builder.Entity<Customer>()
                .HasOne(a => a.CustomerContactInformation).WithOne(b => b.Customer)
                .HasForeignKey<CustomerContactInformation>(e => e.CustomerRef);

            ///Budowa relacji wiele do wielu przy pomocy tabeli pośredniczoncej

            builder.Entity<ItemTag>()
                .HasKey(it => new { it.ItemId, it.TagId });

            builder.Entity<ItemTag>()
                .HasOne<Item>(it => it.Item)
                .WithMany(i => i.ItemTags)
                .HasForeignKey(it => it.ItemId);

            builder.Entity<ItemTag>()
                .HasOne<Tag>(it => it.Tag)
                .WithMany(t => t.ItemTags)
                .HasForeignKey(it => it.TagId);

        }
    }
}
