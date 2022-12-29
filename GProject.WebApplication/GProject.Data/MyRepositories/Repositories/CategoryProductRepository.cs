using GProject.Data.Context;
using GProject.Data.DomainClass;
using GProject.Data.MyRepositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GProject.Data.MyRepositories.IRepositories
{
    public class CategoryProductRepository:ICategoryProductRepository
    {
        private GProjectContext _context;
        public CategoryProductRepository()
        {
            _context = new GProjectContext();
        }
        public bool Add(CategoryProduct obj)
        {
            if (obj == null) return false;
            _context.CategoryProducts.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(CategoryProduct obj)
        {
            if (obj == null) return false;
            _context.CategoryProducts.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public bool Update(CategoryProduct obj)
        {
            if (obj == null) return false;
            _context.CategoryProducts.Update(obj);
            _context.SaveChanges();
            return true;
        }

        public List<CategoryProduct> GetAll()
        {
            return _context.CategoryProducts.ToList();
        }
    }
}
