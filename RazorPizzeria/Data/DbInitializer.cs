using RazorPizzeria.Models;

namespace RazorPizzeria.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PizzeriaContext context)
        {
            context.Database.EnsureCreated();

            if (!context.FoodCategories.Any())
            {
                var foodCategories = new FoodCategories[]
                {
                    new FoodCategories{CategoryName="Pizzas"},
                    new FoodCategories{CategoryName="Bebidas"},
                    new FoodCategories{CategoryName="Entrantes"},
                    new FoodCategories{CategoryName="Postres"}
                };

                foreach (FoodCategories item in foodCategories)
                    context.FoodCategories.Add(item);
                context.SaveChanges();
            }

            if (!context.FoodItems.Any())
            {
                var foodItems = new FoodItems[]
                {
                    new FoodItems{Name="Pizza Margarita", price=8.95M, FoodCategoryId=1},
                    new FoodItems{Name="Pizza Barbacoa", price=12.95M, FoodCategoryId=1},
                    new FoodItems{Name="Pizza Procciuto", price=10.95M, FoodCategoryId=1},
                    new FoodItems{Name="Pizza Napolitana", price=10.95M, FoodCategoryId=1},
                    new FoodItems{Name="Pizza Quattro Formaggi", price=12.95M, FoodCategoryId=1}
                };

                foreach (FoodItems item in foodItems)
                    context.FoodItems.Add(item);
                context.SaveChanges();
            }
        }
    }
}
