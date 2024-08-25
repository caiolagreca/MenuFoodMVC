﻿// <auto-generated />
using MenuMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MenuMVC.Migrations
{
    [DbContext(typeof(MenuContext))]
    [Migration("20240825054239_Initial Migration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MenuMVC.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "data:image/jpeg;base64,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",
                            Name = "Margherita",
                            Price = 7.5
                        });
                });

            modelBuilder.Entity("MenuMVC.Models.DishIngredient", b =>
                {
                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("DishId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("DishIngredients");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            IngredientId = 1
                        },
                        new
                        {
                            DishId = 1,
                            IngredientId = 2
                        });
                });

            modelBuilder.Entity("MenuMVC.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tomato Sauce"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mozzarella"
                        });
                });

            modelBuilder.Entity("MenuMVC.Models.DishIngredient", b =>
                {
                    b.HasOne("MenuMVC.Models.Dish", "Dish")
                        .WithMany("DishIngredients")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MenuMVC.Models.Ingredient", "Ingredient")
                        .WithMany("DishIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("MenuMVC.Models.Dish", b =>
                {
                    b.Navigation("DishIngredients");
                });

            modelBuilder.Entity("MenuMVC.Models.Ingredient", b =>
                {
                    b.Navigation("DishIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
