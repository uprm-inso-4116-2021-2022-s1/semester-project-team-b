﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SList.Domain.Models;

namespace SList.Domain.Migrations
{
    [DbContext(typeof(SListContext))]
    [Migration("20210926210657_initial_migration")]
    partial class initial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SList.Domain.Models.Appliance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

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
                        .HasColumnName("id");

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

                    b.Property<int?>("CommentId")
                        .HasColumnType("int")
                        .HasColumnName("comment_id");

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

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
                        .HasColumnName("id");

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

                    b.Property<int?>("ApplianceId")
                        .HasColumnType("int")
                        .HasColumnName("appliance_id");

                    b.Property<int?>("IngredientId")
                        .HasColumnType("int")
                        .HasColumnName("ingredient_id");

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
                        .HasColumnName("id");

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

                    b.Property<int?>("ApplianceId")
                        .HasColumnType("int")
                        .HasColumnName("appliance_id");

                    b.Property<int?>("CommentId")
                        .HasColumnType("int")
                        .HasColumnName("comment_id");

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("created_at");

                    b.Property<int?>("IngredientId")
                        .HasColumnType("int")
                        .HasColumnName("ingredient_id");

                    b.Property<int?>("RatingId")
                        .HasColumnType("int")
                        .HasColumnName("rating_id");

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

            modelBuilder.Entity("SList.Domain.Models.Appliance", b =>
                {
                    b.HasOne("SList.Domain.Models.Pantry", "Pantry")
                        .WithMany("Appliances")
                        .HasForeignKey("Id")
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Recipe", "Recipe")
                        .WithOne("Appliance")
                        .HasForeignKey("SList.Domain.Models.Appliance", "Id")
                        .IsRequired();

                    b.Navigation("Pantry");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("SList.Domain.Models.Comment", b =>
                {
                    b.HasOne("SList.Domain.Models.Forum", "IdNavigation")
                        .WithOne("CommentIdNavigation")
                        .HasForeignKey("SList.Domain.Models.Comment", "Id")
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Recipe", "Recipe")
                        .WithOne("Comments")
                        .HasForeignKey("SList.Domain.Models.Comment", "Id")
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Comment", "Parent")
                        .WithMany("InverseParent")
                        .HasForeignKey("ParentId");

                    b.HasOne("SList.Domain.Models.Forum", "Post")
                        .WithMany("CommentPosts")
                        .HasForeignKey("PostId");

                    b.HasOne("SList.Domain.Models.Recipe", "PostNavigation")
                        .WithMany("CommentPostNavigations")
                        .HasForeignKey("PostId");

                    b.HasOne("SList.Domain.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("IdNavigation");

                    b.Navigation("Parent");

                    b.Navigation("Post");

                    b.Navigation("PostNavigation");

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

            modelBuilder.Entity("SList.Domain.Models.Ingredient", b =>
                {
                    b.HasOne("SList.Domain.Models.Pantry", "Pantry")
                        .WithMany("Ingredients")
                        .HasForeignKey("Id")
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.Recipe", "Recipe")
                        .WithOne("Ingredient")
                        .HasForeignKey("SList.Domain.Models.Ingredient", "Id")
                        .IsRequired();

                    b.Navigation("Pantry");

                    b.Navigation("Recipe");
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
                        .WithOne("Rating")
                        .HasForeignKey("SList.Domain.Models.Rating", "Id")
                        .IsRequired();

                    b.HasOne("SList.Domain.Models.User", "User")
                        .WithMany()
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
                    b.Navigation("CommentIdNavigation");

                    b.Navigation("CommentPosts");
                });

            modelBuilder.Entity("SList.Domain.Models.Pantry", b =>
                {
                    b.Navigation("Appliances");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("SList.Domain.Models.Recipe", b =>
                {
                    b.Navigation("Appliance");

                    b.Navigation("CommentPostNavigations");

                    b.Navigation("Comments");

                    b.Navigation("Ingredient");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("SList.Domain.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Forums");

                    b.Navigation("Pantries");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
