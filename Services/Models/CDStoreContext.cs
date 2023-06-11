using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Services.Models
{
    public partial class CDStoreContext : DbContext
    {
        public CDStoreContext()
        {
        }

        public CDStoreContext(DbContextOptions<CDStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<Cdalbum> Cdalbums { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:CDStoreDB"];
            return strConn;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.PassWord)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("passWord")
                    .IsFixedLength(true);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("roleId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK__Activity__0FC9CBECCFE567B0");

                entity.ToTable("ActivityLog");

                entity.Property(e => e.ActivityId).HasColumnName("activityId");

                entity.Property(e => e.AccountId).HasColumnName("accountId");

                entity.Property(e => e.Activity)
                    .HasMaxLength(1)
                    .HasColumnName("activity");

                entity.Property(e => e.ActivityDate)
                    .HasColumnType("date")
                    .HasColumnName("activityDate");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ActivityL__accou__2F10007B");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ActivityL__reque__300424B4");
            });

            modelBuilder.Entity<Cdalbum>(entity =>
            {
                entity.HasKey(e => e.AlbumId)
                    .HasName("PK__CDAlbum__75BF3ECF5EB5ED48");

                entity.ToTable("CDAlbum");

                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.AlbumGenre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("albumGenre");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("albumName");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("author");

                entity.Property(e => e.Description)
                    .HasMaxLength(4000)
                    .HasColumnName("description");

                entity.Property(e => e.ImgSrc)
                    .HasMaxLength(4000)
                    .HasColumnName("imgSrc");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReleaseYear).HasColumnName("releaseYear");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("Request");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("customerName");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubmitDate)
                    .HasColumnType("date")
                    .HasColumnName("submitDate");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("roleId");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.ToTable("Song");

                entity.Property(e => e.SongId).HasColumnName("songId");

                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("duration");

                entity.Property(e => e.SongName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("songName");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Songs)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Song__albumId__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
