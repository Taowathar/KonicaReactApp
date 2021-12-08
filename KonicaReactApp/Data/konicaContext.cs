using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using KonicaReactApp.Models;

#nullable disable

namespace KonicaReactApp.Data
{
    public partial class konicaContext : DbContext
    {
        public konicaContext(DbContextOptions<konicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Document> Dokumentumok { get; set; }
        public virtual DbSet<Esemeny> Esemenyek { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Naplo> Naplos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DbConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("dokumentumok");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("extension");

                entity.Property(e => e.MainId).HasColumnName("main_id");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("source");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Esemeny>(entity =>
            {
                entity.ToTable("esemeny");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<EventType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClientIpAddress)
                    .HasMaxLength(50)
                    .HasColumnName("Client_IP_address");

                entity.Property(e => e.EventId).HasColumnName("Event_id");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(50)
                    .HasColumnName("Login_name");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Login_time");

                entity.HasOne(d => d.Event)
                    .WithMany()
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_Logins_EventTypes");
            });

            modelBuilder.Entity<Naplo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("naplo");

                entity.Property(e => e.DokumentumId).HasColumnName("dokumentum_id");

                entity.Property(e => e.EsemenyId).HasColumnName("esemeny_id");

                entity.Property(e => e.HappenedAt).HasColumnName("happened_at");

                entity.HasOne(d => d.Dokumentum)
                    .WithMany()
                    .HasForeignKey(d => d.DokumentumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_naplo_dokumentumok");

                entity.HasOne(d => d.Esemeny)
                    .WithMany()
                    .HasForeignKey(d => d.EsemenyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_naplo_esemeny");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Password");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Salt");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("UserName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
