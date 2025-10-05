using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace db_project2.Models;

public partial class TipaolxContext : DbContext
{
    public TipaolxContext()
    {
    }

    public TipaolxContext(DbContextOptions<TipaolxContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Advert> Adverts { get; set; }

    public virtual DbSet<Apple> Apples { get; set; }

    public virtual DbSet<Archive> Archives { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=TIPAOLX;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Advert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Adverts__3214EC27EF2DD96A");

            entity.ToTable(tb => tb.HasTrigger("SendToArchive"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bio).IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.DateOfPublication)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Category).WithMany(p => p.Adverts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("Category_Categories");

            entity.HasOne(d => d.Profile).WithMany(p => p.Adverts)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("Profile_Profiles");

            entity.HasOne(d => d.Status).WithMany(p => p.Adverts)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("Status_Statuses");
        });

        modelBuilder.Entity<Apple>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Apples__3214EC2762CA9FEF");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Archive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Archive");

            entity.Property(e => e.Bio).IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.DateOfPublication)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC27FDD5081D");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryName).HasMaxLength(64);
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Chats__3214EC2719456A95");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserOneId).HasColumnName("UserOneID");
            entity.Property(e => e.UserTwoId).HasColumnName("UserTwoID");

            entity.HasOne(d => d.UserOne).WithMany(p => p.ChatUserOnes)
                .HasForeignKey(d => d.UserOneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserOne_users");

            entity.HasOne(d => d.UserTwo).WithMany(p => p.ChatUserTwos)
                .HasForeignKey(d => d.UserTwoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserTwo_users");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Images__3214EC276224C6E1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImageUrl).HasColumnName("ImageURL");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Messages__3214EC27B1290769");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChatId).HasColumnName("ChatID");
            entity.Property(e => e.DateOfSend)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.Mess).IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Chat).WithMany(p => p.Messages)
                .HasForeignKey(d => d.ChatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Chat_users");

            entity.HasOne(d => d.User).WithMany(p => p.Messages)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserMess_users");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Profiles__3214EC27D50EF80A");

            entity.HasIndex(e => e.Userid, "UQ__Profiles__7B9E7F3461B990E4").IsUnique();

            entity.HasIndex(e => e.Banner, "UQ__Profiles__AB47C25A0CC7993A").IsUnique();

            entity.HasIndex(e => e.Avatar, "UQ__Profiles__BFF2A23B51483DF6").IsUnique();

            entity.HasIndex(e => e.Nickname, "UQ__Profiles__CC6CD17E89E6A6A0").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bio).HasColumnName("BIO");
            entity.Property(e => e.Nickname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.VisibleName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AvatarNavigation).WithOne(p => p.ProfileAvatarNavigation)
                .HasForeignKey<Profile>(d => d.Avatar)
                .HasConstraintName("Avatar");

            entity.HasOne(d => d.BannerNavigation).WithOne(p => p.ProfileBannerNavigation)
                .HasForeignKey<Profile>(d => d.Banner)
                .HasConstraintName("Banner");

            entity.HasOne(d => d.User).WithOne(p => p.Profile)
                .HasForeignKey<Profile>(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("USERID");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ratings__3214EC27663FCB60");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Grade).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.SellerId).HasColumnName("SellerID");
            entity.Property(e => e.SenderId).HasColumnName("SenderID");

            entity.HasOne(d => d.Seller).WithMany(p => p.RatingSellers)
                .HasForeignKey(d => d.SellerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SellerID_Profiles");

            entity.HasOne(d => d.Sender).WithMany(p => p.RatingSenders)
                .HasForeignKey(d => d.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SenderID_Profiles");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Statuses__3214EC27F44F1952");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StatusName).HasMaxLength(64);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC2717492C3D");

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534014172FF").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateOfRegistration).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(64);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
