using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Data;
using RazorPizzeria.Models;
using static System.Net.Mime.MediaTypeNames;

namespace RazorPizzeria.Services
{
    public class FoodItemsService
    {
        private readonly PizzeriaContext _PizzaContext;
        public FoodItemsService(PizzeriaContext pizzaContext) 
        { 
            _PizzaContext= pizzaContext;
        }

        public List<FoodItems> GetAllFoodItems()
        { 
            if (_PizzaContext.FoodItems != null)
                return _PizzaContext.FoodItems.ToList();
            return new List<FoodItems>();
        }

        public List<FoodItems> GetAllFoodItemsByCategory(int foodCategory)
        {
            if (_PizzaContext.FoodItems != null)
            {
                return _PizzaContext.FoodItems
                    .Include(fi => fi.FoodCategory)
                    .Include(fi => fi.FoodSize)
                    .Where(x => x.FoodCategoryId == foodCategory)
                    .ToList();
            }
                
            return new List<FoodItems>();
        }

        public FoodItems? GetFoodItem(int id)
        {
            if (_PizzaContext.FoodItems != null)
                return _PizzaContext.FoodItems.FirstOrDefault(x => x.Id == id);
            return null;
        }

        public void AddFoodItem(FoodItems food)
        {
            if (_PizzaContext.FoodItems != null)
            {
                _PizzaContext.FoodItems.Add(food);
                _PizzaContext.SaveChanges();
            }
        }

        public void DeleteFoodItem(int id)
        {
            if (_PizzaContext.FoodItems != null)
            {
                FoodItems? food = this.GetFoodItem(id);
                if (food != null)
                    _PizzaContext.FoodItems.Remove(food);
            }
        }
    }
}
