using GProject.Data.DomainClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace GProject.Data.MyRepositories.IRepositories
{
    public interface ICategoryProductRepository
    {
        bool Add(CategoryProduct obj);
        bool Update(CategoryProduct obj);
        bool Delete(CategoryProduct obj);
        List<CategoryProduct> GetAll();
    }
}
