﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TweetWebApi.Models
{
    public partial class TweetDBContext : DbContext
    {
        public TweetDBContext()
        {
        }

        public TweetDBContext(DbContextOptions<TweetDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLogin> TblLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=LAPTOP-IBOPJQ1B;Initial Catalog=TweetDB;Integrated Security=True");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.ConfirmPassword).HasMaxLength(100);

                entity.Property(e => e.ContactNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LoginId).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
