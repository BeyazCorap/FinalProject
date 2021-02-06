using Core.DataAccess.Entity_framework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory.Entity_Framerwork
{
    public class EFProductDal : EFEntityRepositoryBase<Product,NorthwindConetext>, IProductDal
    {
       
    }
}
