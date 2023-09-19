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
                    new FoodCategories{CategoryName="Drinks"},
                    new FoodCategories{CategoryName="starters"},
                    new FoodCategories{CategoryName="Desserts"}
                };

                foreach (FoodCategories item in foodCategories)
                    context.FoodCategories.Add(item);
                context.SaveChanges();
            }

            if (!context.FoodSizes.Any()) 
            {
                var foodSizes = new FoodSizes[]
                {
                    new FoodSizes{Size="Small"},
                    new FoodSizes{Size="Medium"},
                    new FoodSizes{Size="Large"}
                };
                foreach (FoodSizes item in foodSizes)
                    context.FoodSizes.Add(item);
                context.SaveChanges();
            }

            if (!context.FoodItems.Any())
            {
                var foodItems = new FoodItems[]
                {
                    new FoodItems{Name="Pizza Margarita", IsGlutenFree=false, Price=8.95M, FoodCategoryId=1, FoodSizeId=1, Description="Classic italian pizza with tomato, mozzarella and basel"},
                    new FoodItems{Name="Pizza Barbacoa", IsGlutenFree=false, Price=12.95M, FoodCategoryId=1, FoodSizeId=1, Description="Bacon, chicken, mozzarella and delicious bbq sauce"},
                    new FoodItems{Name="Pizza Procciuto", IsGlutenFree=false, Price=10.95M, FoodCategoryId=1, FoodSizeId=1, Description="Classic italian pizza with tomato, ham and mozzarella cheese"},
                    new FoodItems{Name="Pizza Pepperoni", IsGlutenFree=false, Price=10.95M, FoodCategoryId=1, FoodSizeId=1, Description="Pizza with tomato, mozzarella y double portion of pepperoni"},
                    new FoodItems{Name="Pizza Quattro Formaggi", IsGlutenFree=false, Price=12.95M, FoodCategoryId=1, FoodSizeId=1, Description="Classic italian pizza with mozzarella, gorgonzola, fontina and parmesan cheese"},
                    new FoodItems{Name="French Fries", IsGlutenFree=false, Price=6.95M, FoodCategoryId=3, FoodSizeId=1, Description="Delicious french fries from good quality potatoes"},
                    new FoodItems{Name="Chicken Nuggets", IsGlutenFree=false, Price=5.99M, FoodCategoryId=3, FoodSizeId=1, Description="Crispy Chicken nuggets"},
                    new FoodItems{Name="Nachos", IsGlutenFree=false, Price=8.99M, FoodCategoryId=3, FoodSizeId=1, Description="Nachos with steaming hot delicious nacho cheese"},
                    new FoodItems{Name="Fried Cheese Bites", IsGlutenFree=false, Price=6.99M, FoodCategoryId=3, FoodSizeId=1, Description="Delicious fried cheese with a crispy crust"},
                };

                foreach (FoodItems item in foodItems)
                    context.FoodItems.Add(item);
                context.SaveChanges();
            }
        }
    }
}
