using Api_LoginMvc.Dto;
using Api_LoginMvc.Model;
using System;
using Xunit;

namespace LoginMvcTeste
{
    public class ResultadoCadastroUsuarioDtoTests
    {
        private ResultadoCadastroUsuarioDto _Dto;

        [Fact]
        public void CheckCheckReturnUser()
        {


            var user = new Usuario
            {
                Nome = "Felipe",
                SobreNome = "Chamone",
                Email = "Acessotichamone@hotmail.com",
                Telefone = "31000000000"
            };

            var e = new ResultadoCadastroUsuarioDto(Guid.NewGuid(), DateTime.Now,DateTime.Now, user.Last_login, user.Nome,user.SobreNome,user.Email, user.Telefone);


            //controller.StatusCode.Should().Be(HttpStatusCode.OK);

            //Act


            //Assert

        }
    }
}
