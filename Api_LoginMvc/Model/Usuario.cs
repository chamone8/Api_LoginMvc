using Api_LoginMvc.Model.Interface;
using System;

namespace Api_LoginMvc.Model
{
    public class Usuario : IModelBase
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }


        public void insertIdAndCreated()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }
        public void modified_currentDate()
        {
            Modified = DateTime.Now;
        }
        public void lastLogin_CurrentDate()
        {
            Last_login = DateTime.Now;
        }
    }
}