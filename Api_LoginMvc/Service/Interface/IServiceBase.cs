using System;
using System.Collections;
using System.Collections.Generic;

namespace Api_LoginMvc.Service.Interface
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity Login(string email, string password);
    }
}
