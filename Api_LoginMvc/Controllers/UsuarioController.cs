using Api_LoginMvc.Commads;
using Api_LoginMvc.Dto;
using Api_LoginMvc.Model;
using Api_LoginMvc.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Api_LoginMvc.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ServiceLogin _service;

        public UsuarioController(ServiceLogin serviceLogin)
        {
            _service = serviceLogin;
        }

        [HttpPost("Cadastro")]
        public ActionResult<dynamic> Post([FromBody] Usuario usuario)
        {
            try
            {
                if (!QuerysGlobal.FindExistingUser(usuario.Email))
                {
                    var user = _service.Add(usuario);

                    if (user == null)
                        return new { mensagem = StatusCode((int)HttpStatusCode.InternalServerError, "Usuario não cadastrado") };

                    var dtoResult = new ResultadoCadastroUsuarioDto(user.Id, user.Created, user.Modified, user.Last_login, user.Nome, user.SobreNome, user.Email, user.Telefone);
                    return dtoResult;
                }
                else
                {
                    return new { Mensagem = "E-mail já existente" };
                }
            }
            catch (Exception ex)
            {
                return new { MensagemErro = StatusCode((int)HttpStatusCode.InternalServerError, ex.Message)};
            }
        }

        [HttpPost("Login")]
        public ActionResult<dynamic> Login([FromBody]Login login)
        {
            try
            {
                if (!string.IsNullOrEmpty(login.Email) && !string.IsNullOrEmpty(login.Password))
                {
                    if (QuerysGlobal.FindExistingUser(login.Email))
                    {
                        var user = _service.Login(login.Email, login.Password);
                        var token = TokenService.GenerateToken(user);

                        if (user == null)
                            return NotFound(new { codigo = StatusCode((int)HttpStatusCode.NonAuthoritativeInformation), Mensagem = "Usuario não encontrado!!" });

                        var dtoResult = new ResultadoCadastroUsuarioDto(user.Id, user.Created, user.Modified, user.Last_login, user.Nome, user.SobreNome, user.Email, user.Telefone);
                        return new
                        {
                            user = dtoResult,
                            token = token
                        };
                    }
                    else
                    {
                        return new { MensagemErro = StatusCode((int)HttpStatusCode.Unauthorized, "Usuário ou senha inválidos") };
                    }
                }
                return new { MensagemErro = StatusCode((int)HttpStatusCode.Unauthorized, "Campos Login e Senha são obrigatorios") };
            }
            catch (Exception ex)
            {
                return new { MensagemErro = StatusCode((int)HttpStatusCode.Unauthorized, ex.Message) };
            }

        }

        
    }
}
