﻿
using Models.Tables;
using Persistences.Contexts;
using System.Data.Entity;
using System.Linq;


namespace Persistences.Dall.Tables
{
   public  class CategoryDall
    {
        private EFContext context = new EFContext();
        public IQueryable<Category> GetCategoryOrderedByName()
        {
            return context.Categories.OrderBy(b => b.Nome);
        }
        public Category GetCategoryForId(long id)
        {
                return context.Categories
                .Where(s => s.CategoryId == id)
                .Include(s => s.Products)
                .First();
        }
        public void SaveCategory(Category category)
        {
            if (category.CategoryId == null)
            {
                context.Categories.Add(category);
            }
            else
            {
                context.Entry(category).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Category DeleteCategoryForId(long id)
        {
            Category category = GetCategoryForId(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return category;
        }
    }
}
