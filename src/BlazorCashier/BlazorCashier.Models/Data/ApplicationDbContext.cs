﻿using BlazorCashier.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorCashier.Models.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="options">Options to configure the DbContext</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        #endregion

        #region Tables 
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<CashierPayment> CashierPayments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountItem> DiscountItems { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Item> Items { get; set; }
        #endregion

        #region Public Methods

        /// <summary>
        /// Does configurations when models are creates
        /// </summary>
        /// <param name="builder">Builder to use for doing the configurations</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Initialize 
            builder.Entity<Country>()
                .HasData(new Country() { Code = "LB", CultureCode = "ar-LB", Name = "Lebanon", Id = Guid.NewGuid().ToString() });
            builder.Entity<Currency>()
                .HasData(new Currency() { Id = Guid.NewGuid().ToString(), Name = "Dollar", Code = "USD", Symbol = "$" });

            base.OnModelCreating(builder);
        }

        /// <summary>
        /// Saves all changes made in this context to the database
        /// </summary>
        /// <returns>The number of state entries written to the database</returns>
        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        #endregion
    }
}
