using Api_LoginMvc.Common;
using Api_LoginMvc.Context;
using Api_LoginMvc.Model;
using Api_LoginMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api_LoginMvc.Repository
{
    public class RepositoryLogin : IRepositoryBase<Usuario>, IJwtAuthenticationManager
    {
        private readonly BancoDados _bancoDados;
        public readonly Usuario _usuarioModel;
        public RepositoryLogin(BancoDados bancoDados, Usuario usuarioModel)
        {
            _bancoDados = bancoDados;
            _usuarioModel = usuarioModel;
        }

        //metodo adicionar usuario
        public Usuario Add(Usuario entity)
        {
            if (entity != null && !string.IsNullOrEmpty(entity.ToString()))
            {
                try
                {
                    entity.insertIdAndCreated();
                    entity.lastLogin_CurrentDate();
                    entity.Senha = BCrypt.Net.BCrypt.HashPassword(entity.Senha);
                    Global.Usuarios.Add(entity);
                    return entity;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return null;

        }

        //metodo criado para ser usado posteriomente, não foi implementado no controller
        public void Delete(Usuario entity)
        {
            _bancoDados.Remove(entity);
            _bancoDados.SaveChanges();
        }

        //metodo login
        public Usuario Login(string Email, string Password)
        {
            Usuario user = Global.Usuarios.SingleOrDefault(x => x.Email == Email);

            user.lastLogin_CurrentDate();
            _bancoDados.SaveChanges();

            if (user == null)
                return null;

            bool isValidPassord = BCrypt.Net.BCrypt.Verify(Password, user.Senha);

            //validar senha do usuario
            if (!isValidPassord)
            {
                throw new Exception("Usuario ou Senha incorreto!!!");
            }
            return (Usuario)user;
        }

        //metodo usado para listar todos os usuarios cadastrados, achei interessante implementar 
        public IEnumerable<Usuario> GetAll()
        {
            return new List<Usuario>();
        }

        //metodo criado para ser usado posteriomente, não foi implementado no controller
        public void Update(Usuario obj)
        {
            _bancoDados.Entry(obj).State = EntityState.Modified;
            _bancoDados.SaveChanges();
        }

        public string Authenticate(string usuario, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
