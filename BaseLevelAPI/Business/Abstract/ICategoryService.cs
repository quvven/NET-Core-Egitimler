﻿using Common.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<Category>> GetList();

        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
