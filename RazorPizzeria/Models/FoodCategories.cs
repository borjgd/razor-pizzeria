namespace RazorPizzeria.Models
{
    public class FoodCategories
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = default!;
    }

    enum Categories
    {
        Pizzas = 1,
        Drinks = 2,
        Starters = 3,
        Desserts = 4
    }
}
