using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SList.Domain.Models
{
    public partial class SListContext : DbContext
    {
        public SListContext()
        {
        }

        public SListContext(DbContextOptions<SListContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Appliance> Appliances { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Forum> Forums { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Pantry> Pantries { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Note: this should not be excuted ever since we are always providing the optionBuilder through dependacy injection 
                optionsBuilder.UseSqlServer("Server=localhost;Database=SList;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Appliance>(entity =>
            {
                entity.ToTable("appliances");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasMany(d => d.Pantries)
                    .WithMany(p => p.Appliances);

                entity.HasMany(d => d.Recipes)
                    .WithMany(p => p.Appliances);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comments");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Forum>(entity =>
            {
                entity.ToTable("forum");
                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Forums)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("ingredients");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasMany(d => d.Pantries)
                    .WithMany(p => p.Ingredients);

                entity.HasMany(d => d.Recipes)
                    .WithMany(p => p.Ingredients);
            });

            modelBuilder.Entity<Pantry>(entity =>
            {
                entity.ToTable("pantries");

                entity.Property(e => e.Id).HasColumnName("id");


                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.HasMany(d => d.Ingredients)
                    .WithMany(i => i.Pantries);

                entity.HasMany(d => d.Appliances)
                    .WithMany(a => a.Pantries);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pantries)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("ratings");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rating");

                entity.Property(e => e.RecipeId).HasColumnName("recipe_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(e => e.User)
                    .WithMany(u => u.Ratings)
                    .HasForeignKey(e => e.UserId);

                entity.HasOne(d => d.Reciepe)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.ToTable("recipes");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.UserId);
                entity.Property(e => e.CookTime).HasColumnName("cook_duration");
                entity.Property(e => e.PrepTime).HasColumnName("prepation_duration");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Email, "UQ__users__AB6E616487F65749")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "UQ__users__F3DBC57228EAD4FE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
