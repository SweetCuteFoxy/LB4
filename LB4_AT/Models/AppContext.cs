using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LB4_AT.Models;

public partial class AppContext : DbContext
{
    public AppContext()
    {
    }

    public AppContext(DbContextOptions<AppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnimeTittle> AnimeTittles { get; set; }

    public virtual DbSet<AnimeType> AnimeTypes { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=animeTitles;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnimeTittle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("AnimeTittles_pkey");

            entity.HasOne(d => d.IdOfAnimeTypeNavigation).WithMany(p => p.AnimeTittles)
                .HasForeignKey(d => d.IdOfAnimeType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tittle_types");

            entity.HasOne(d => d.IdOfGenreNavigation).WithMany(p => p.AnimeTittles)
                .HasForeignKey(d => d.IdOfGenre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tittles_genres");

            entity.HasOne(d => d.IdOfUserNavigation).WithMany(p => p.AnimeTittles)
                .HasForeignKey(d => d.IdOfUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tittles_moderators");
        });

        modelBuilder.Entity<AnimeType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animeTypes_pkey");

            entity.ToTable("animeTypes");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Genres_pkey");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Users_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
