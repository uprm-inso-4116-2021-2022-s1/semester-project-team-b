﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SList.Domain.Models;

namespace SList.Domain.Migrations
{
    [DbContext(typeof(SListContext))]
    partial class SListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppliancePantry", b =>
                {
                    b.Property<int>("AppliancesId")
                        .HasColumnType("int");

                    b.Property<int>("PantriesId")
                        .HasColumnType("int");

                    b.HasKey("AppliancesId", "PantriesId");

                    b.HasIndex("PantriesId");

                    b.ToTable("AppliancePantry");
                });

            modelBuilder.Entity("ApplianceRecipe", b =>
                {
                    b.Property<int>("AppliancesId")
                        .HasColumnType("int");

                    b.Property<int>("RecipesId")
                        .HasColumnType("int");

                    b.HasKey("AppliancesId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("ApplianceRecipe");
                });

            modelBuilder.Entity("IngredientPantry", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("PantriesId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsId", "PantriesId");

                    b.HasIndex("PantriesId");

                    b.ToTable("IngredientPantry");
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.Property<int>("IngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("RecipesId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("SList.Domain.Models.Appliance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("appliances");
                });

            modelBuilder.Entity("SList.Domain.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("parentId");

                    b.Property<int?>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("post_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("SList.Domain.Models.Forum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("forum");
                });

            modelBuilder.Entity("SList.Domain.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("Id");

                    b.ToTable("ingredients");
                });

            modelBuilder.Entity("SList.Domain.Models.Pantry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("name");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("pantries");
                });

            modelBuilder.Entity("SList.Domain.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Rate")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("recipe_id");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("ratings");
                });

            modelBuilder.Entity("SList.Domain.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("SList.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updated_at");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "UQ__users__AB6E616487F65749")
                        .IsUnique()
                        .HasFilter("[email] IS NOT NULL");

                    b.HasIndex(new[] { "Username" }, "UQ__users__F3DBC57228EAD4FE")
                        .IsUnique()
                        .HasFilter("[username] IS NOT NULL");

                    b.ToTable("users");
                });

            modelBuilder.Entity("AppliancePantry", b =>
                {
                    b.HasOne("SList.Domain.Models.Appliance", null)
                        .WithMany()
                        .HasForeignKey("AppliancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Pantry", null)
                        .WithMany()
                        .HasForeignKey("PantriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplianceRecipe", b =>
                {
                    b.HasOne("SList.Domain.Models.Appliance", null)
                        .WithMany()
                        .HasForeignKey("AppliancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IngredientPantry", b =>
                {
                    b.HasOne("SList.Domain.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Pantry", null)
                        .WithMany()
                        .HasForeignKey("PantriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.HasOne("SList.Domain.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SList.Domain.Models.Comment", b =>
                {
                    b.HasOne("SList.Domain.Models.Comment", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId");

                    b.HasOne("SList.Domain.Models.Forum", "Forum")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.HasOne("SList.Domain.Models.Recipe", "Recipe")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.HasOne("SList.Domain.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("Forum");

                    b.Navigation("Parent");

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SList.Domain.Models.Forum", b =>
                {
                    b.HasOne("SList.Domain.Models.User", "User")
                        .WithMany("Forums")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SList.Domain.Models.Pantry", b =>
                {
                    b.HasOne("SList.Domain.Models.User", "User")
                        .WithMany("Pantries")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SList.Domain.Models.Rating", b =>
                {
                    b.HasOne("SList.Domain.Models.Recipe", "Reciepe")
                        .WithMany("Ratings")
                        .HasForeignKey("RecipeId");

                    b.HasOne("SList.Domain.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId");

                    b.Navigation("Reciepe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SList.Domain.Models.Recipe", b =>
                {
                    b.HasOne("SList.Domain.Models.User", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SList.Domain.Models.Comment", b =>
                {
                    b.Navigation("InverseParent");
                });

            modelBuilder.Entity("SList.Domain.Models.Forum", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("SList.Domain.Models.Recipe", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("SList.Domain.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Forums");

                    b.Navigation("Pantries");

                    b.Navigation("Ratings");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
