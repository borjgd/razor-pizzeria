using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;
using RazorPizzeria.Services;

namespace RazorPizzeria.Pages
{
    public class PizzasModel : PageModel
    {
        private readonly FoodItemsService _FoodItemsService;
        public List<FoodItems> Pizzas { get; set; } = default!;
        public PizzasModel(FoodItemsService foodItemsService) 
        { 
            _FoodItemsService= foodItemsService;
        }
        public void OnGet()
        {
            Pizzas = _FoodItemsService.GetAllFoodItemsByCategory(1);
        }
    }
}
