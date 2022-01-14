using Api_LoginMvc.Dto;
using Api_LoginMvc.Model;
using System;
using Xunit;
using FluentAssertions;

namespace LoginMvcTeste
{
    public class ResultadoCadastroUsuarioDtoTests
    {


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

            //Act
            var returnDto = new ResultadoCadastroUsuarioDto(Guid.NewGuid(), DateTime.Now, DateTime.Now, user.Last_login, user.Nome, user.SobreNome, user.Email, user.Telefone);

            //Assert
            returnDto.Should().NotBeNull();
            returnDto.Should().NotBeOfType(typeof(Usuario));
            returnDto.Profiles.Nome.Should().NotBeNull();
            returnDto.Profiles.SobreNome.Should().NotBeNull();
            returnDto.Profiles.Telefone.Should().NotBeNull();
            returnDto.Profiles.Email.Should().NotBeNull();


        }

        [Fact]
        public void CheckReturnUserNull()
        {


            var user = new Usuario{};

            //Act
            var returnDto = new ResultadoCadastroUsuarioDto(Guid.NewGuid(), DateTime.Now, DateTime.Now, user.Last_login, user.Nome, user.SobreNome, user.Email, user.Telefone);

            //Assert
            returnDto.Profiles.Nome.Should().BeNull();
            returnDto.Profiles.SobreNome.Should().BeNull();
            returnDto.Profiles.Telefone.Should().BeNull();
            returnDto.Profiles.Email.Should().BeNull();
            returnDto.Should().NotBeOfType(typeof(Usuario));


        }
    }
}
