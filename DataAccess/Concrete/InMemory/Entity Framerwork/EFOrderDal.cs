using Core.DataAccess.Entity_framework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory.Entity_Framerwork
{
    public class EFOrderDal : EFEntityRepositoryBase<Order, NorthwindConetext>, IOrderDal
    {
    }
}
