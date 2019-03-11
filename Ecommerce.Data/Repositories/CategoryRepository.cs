﻿using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Data.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private EcommerceContext _context;

        public CategoryRepository(EcommerceContext context)
        {
            _context = context;
        }

        public Category Add(Category entity)
        {
            Category newCategory = new Category();

            try
            {
                newCategory = _context.Categories.Add(entity);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }

            return newCategory;
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public Category Get(int Id)
        {
            return _context.Categories.Single(cat => cat.Id == Id);
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories;
        }

        public Category GetSingle(Func<Category, bool> predicate)
        {
            return _context.Categories.SingleOrDefault(predicate);
        }

        public Category Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}