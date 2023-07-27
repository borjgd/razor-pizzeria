using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.DTOs;
using RazorPizzeria.Models;
using RazorPizzeria.Services;

namespace RazorPizzeria.Pages
{
    public class StartersModel : PageModel
    {
        private readonly FoodItemsService _FoodItemsService;
        public List<FoodDTO> Starters { get; set; } = default!;
        public StartersModel(FoodItemsService foodItemsService)
        {
            _FoodItemsService = foodItemsService;
        }
        public void OnGet()
        {
            Starters = _FoodItemsService.GetAllFoodItemsByCategory(Convert.ToInt16(Categories.Starters));
        }
    }
}
