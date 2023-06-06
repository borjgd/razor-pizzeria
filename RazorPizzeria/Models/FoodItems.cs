namespace RazorPizzeria.Models
{
    public class FoodItems
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }
        public bool IsGlutenFree { get; set; } = default!;
        public int FoodCategoryId { get; set; }
        public int FoodSizeId { get; set; }
        public FoodCategories FoodCategory { get; set; } = default!;
        public FoodSizes FoodSize { get; set; } = default!;
    }
}
