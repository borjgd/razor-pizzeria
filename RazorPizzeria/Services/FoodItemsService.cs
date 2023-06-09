using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Data;
using RazorPizzeria.DTOs;
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

        public List<FoodDTO> GetAllFoodItems()
        { 
            if (_PizzaContext.FoodItems != null)
                return _PizzaContext.FoodItems
                    .Include(fi => fi.FoodCategory)
                    .Include(fi => fi.FoodSize)
                    .Select(q => new FoodDTO()
                    {
                        Id = q.Id,
                        Food = q.Name,
                        IsGlutenFree = q.IsGlutenFree,
                        Size = q.FoodSize.Size,
                        Category = q.FoodCategory.CategoryName,
                        Price = q.Price
                    })
                    .ToList();
            return new List<FoodDTO>();
        }

        public List<FoodDTO> GetAllFoodItemsByCategory(int foodCategory)
        {
            if (_PizzaContext.FoodItems != null)
            {
                return _PizzaContext.FoodItems
                    .Include(fi => fi.FoodCategory)
                    .Include(fi => fi.FoodSize)
                    .Where(fi => fi.FoodCategoryId == foodCategory)
                    .Select(q => new FoodDTO()
                    {
                        Id = q.Id,
                        Food = q.Name,
                        IsGlutenFree = q.IsGlutenFree,
                        Size = q.FoodSize.Size,
                        Category = q.FoodCategory.CategoryName,
                        Price = q.Price
                    }).ToList();
            }
                
            return new List<FoodDTO>();
        }

        public FoodDTO? GetFoodItem(int id)
        {
            if (_PizzaContext.FoodItems != null)
                return _PizzaContext.FoodItems.Select(q => new FoodDTO()
                {
                    Id = q.Id,
                    Food = q.Name,
                    IsGlutenFree = q.IsGlutenFree,
                    Size = q.FoodSize.Size,
                    Category = q.FoodCategory.CategoryName,
                    Price = q.Price
                }).SingleOrDefault(fi => fi.Id == id);
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
                FoodItems? food = _PizzaContext.FoodItems.FirstOrDefault(f => f.Id == id);
                if (food != null)
                    _PizzaContext.FoodItems.Remove(food);
            }
        }
    }
}
