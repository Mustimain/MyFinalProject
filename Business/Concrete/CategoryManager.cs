using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Business;
using System.Linq;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());

        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        public IResult Add(Category category)
        {
            var result = BusinessRules.Run(CheckIfCategoryNameExist(category.CategoryName));

            if (result != null)
            {
                return result;
            }

            _categoryDal.Add(category);

            return new SuccessResult();
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);

            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);

            return new SuccessResult();
        }

        private IResult CheckIfCategoryNameExist(string categoryName)
        {

            var result = _categoryDal.GetAll(c=>c.CategoryName == categoryName).Any();

            if (result == true)
            {
                return new ErrorResult();
            }
            else
            {
                return new SuccessResult();
            }
            
        }
    }
}
