using MenuMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuMVC.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.DishId,
                di.IngredientId
            });
            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);

            modelBuilder.Entity<Dish>().HasData(
               new Dish { Id = 1, Name = "Margherita", Price = 7.50, ImageUrl = "" },
                new Dish { Id = 2, Name = "Pepperoni", Price = 8.50, ImageUrl = "" },
                new Dish { Id = 3, Name = "BBQ Chicken", Price = 9.00, ImageUrl = "" },
                new Dish { Id = 4, Name = "Hawaiian", Price = 8.00, ImageUrl = "" },
                new Dish { Id = 5, Name = "Veggie Delight", Price = 7.75, ImageUrl = "" }
            );

            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { Id = 1, Name = "Tomato Sauce" },
                new Ingredient { Id = 2, Name = "Mozzarella" },
                new Ingredient { Id = 3, Name = "Pepperoni" },
                new Ingredient { Id = 4, Name = "Chicken" },
                new Ingredient { Id = 5, Name = "BBQ Sauce" },
                new Ingredient { Id = 6, Name = "Pineapple" },
                new Ingredient { Id = 7, Name = "Ham" },
                new Ingredient { Id = 8, Name = "Green Peppers" },
                new Ingredient { Id = 9, Name = "Onions" },
                new Ingredient { Id = 10, Name = "Olives" }
            );
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientId = 1 }, // Margherita -> Tomato Sauce
                new DishIngredient { DishId = 1, IngredientId = 2 }, // Margherita -> Mozzarella
                new DishIngredient { DishId = 2, IngredientId = 1 }, // Pepperoni -> Tomato Sauce
                new DishIngredient { DishId = 2, IngredientId = 2 }, // Pepperoni -> Mozzarella
                new DishIngredient { DishId = 2, IngredientId = 3 }, // Pepperoni -> Pepperoni
                new DishIngredient { DishId = 3, IngredientId = 2 }, // BBQ Chicken -> Mozzarella
                new DishIngredient { DishId = 3, IngredientId = 4 }, // BBQ Chicken -> Chicken
                new DishIngredient { DishId = 3, IngredientId = 5 }, // BBQ Chicken -> BBQ Sauce
                new DishIngredient { DishId = 4, IngredientId = 1 }, // Hawaiian -> Tomato Sauce
                new DishIngredient { DishId = 4, IngredientId = 2 }, // Hawaiian -> Mozzarella
                new DishIngredient { DishId = 4, IngredientId = 6 }, // Hawaiian -> Pineapple
                new DishIngredient { DishId = 4, IngredientId = 7 }, // Hawaiian -> Ham
                new DishIngredient { DishId = 5, IngredientId = 2 }, // Veggie Delight -> Mozzarella
                new DishIngredient { DishId = 5, IngredientId = 8 }, // Veggie Delight -> Green Peppers
                new DishIngredient { DishId = 5, IngredientId = 9 }, // Veggie Delight -> Onions
                new DishIngredient { DishId = 5, IngredientId = 10 } // Veggie Delight -> Olives
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<DishIngredient> DishIngredients { get; set; }


    }
}
