using RazorPizzeria.Data;

namespace RazorPizzeria.Services
{
    public class FoodCategoriesService
    {
        private readonly PizzeriaContext _PizzaContext;

        public FoodCategoriesService(PizzeriaContext pizzaContext)
        {
            _PizzaContext = pizzaContext;
        }

        public List<string> GetAllFoodCategories()
        {
            if (_PizzaContext.FoodCategories != null)
                return _PizzaContext.FoodCategories.Select(q => q.CategoryName).ToList();
            return new List<string>();
        }
    }
}
