using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.DTOs;
using RazorPizzeria.Services;

namespace RazorPizzeria.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FoodCategoriesService _FoodCategoriesService;
        public List<string> Categories { get; set; } = default!;

        public IndexModel(ILogger<IndexModel> logger, FoodCategoriesService foodCategoriesService)
        {
            _logger = logger;
            _FoodCategoriesService = foodCategoriesService;
        }

        public void OnGet()
        {
            Categories = _FoodCategoriesService.GetAllFoodCategories();
        }
    }
}