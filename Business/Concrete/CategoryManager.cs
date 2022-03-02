using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly ICategoryDal _dal;
        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }



        public List<Category> GetAll()
        {
           return _dal.GetAll();    
        }

        public Category GetById(int id)
        {
            return _dal.Get(c=>c.CategoryId==id);
                
        }

        public Category GetByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
