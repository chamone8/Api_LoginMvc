using Api_LoginMvc.Model;
using Api_LoginMvc.Repository;
using Api_LoginMvc.Service.Interface;
using System;
using System.Collections.Generic;

namespace Api_LoginMvc.Service
{
    public class ServiceLogin: IServiceBase<Usuario>
    {
        private readonly RepositoryLogin _repository;

        public ServiceLogin(RepositoryLogin repository)
        {
            _repository = repository;
        }
        public Usuario Add(Usuario entity)
        {
            return  _repository.Add(entity);
        }

        public void Delete(Usuario entity)
        {
            _repository.Delete(entity);
        }

        public Usuario Login(string email, string Password)
        {
            return _repository.Login(email, Password);
        }

        public IEnumerable<Usuario> GetAll()
        {
           return _repository.GetAll();
        }

        
        public void Update(Usuario entity)
        {
            _repository.Update(entity);
        }
    }
}
