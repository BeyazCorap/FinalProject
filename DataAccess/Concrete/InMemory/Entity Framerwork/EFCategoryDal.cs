using Core.Abstract;
using Core.DataAccess.Entity_framework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory.Entity_Framerwork
{
    public class EFCategoryDal : EFEntityRepositoryBase<Category, NorthwindConetext>, ICategoryDal
    {
       
    }
}
