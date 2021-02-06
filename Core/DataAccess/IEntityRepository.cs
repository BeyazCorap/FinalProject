using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Abstract
{
    //IEntity ya da IEntity implemet eden bir class
    //new() : new'lenebilen bir class olsun
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T enitity);
        void Update(T enitity);
        void Delete(T enitity);
        //List<T> GetAllByCategory(int categoryId);
    }
}
