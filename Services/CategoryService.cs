using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDatabase.Models;

namespace TestDatabase.Services
{
    class CategoryService
    {
        private TestContext _context;

        public CategoryService(TestContext context)
        {
            _context = context;
        }

        public void CreateCategory(string n)
        {
            Category category = new Category();

            category.CategoryName = n;

            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public Category GetCategory(string n)
        {
            return _context.Categories.First(c => c.CategoryName == n);
        }

        public void DeleteCategory(string n)
        {
            _context.Remove(GetCategory(n));
            _context.SaveChanges();
        }

        public void RenameCategory(string newN, string oldN)
        {
            Category category = GetCategory(oldN);

            category.CategoryName = newN;

            _context.SaveChanges();
        }

    }
}