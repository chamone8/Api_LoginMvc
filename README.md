<h1 align="center">Projeto Autenticação ... 🚀🚀🚀🚀🚀🚀🚀🚀</h1>
## Projeto foi desenvolvido em .Net Core 5.0.


## :hammer: Funcionalidades do projeto

- `Funcionalidade 1`: No endpoint https://localhost:49155/api/v1/Cadastro é passado um objeto com os dados "nome, sobreNome, email, senha, telefone", o sistema verifica se o email já existe e caso não exista o sistema criptografa a senha e os dados são gravados no banco de dados
- `Funcionalidade 2`: No endpoint https://localhost:49155/api/v1/Login é passando um objeto  com os dados Email e senha, o email vai ser verificado se já existe na base de dados caso exista vai ser apresentado os dados do usuario
- `Funcionalidade 3`: No endpoint https://localhost:49155/api/v1/Login é gerado o token de validação que será expirado a cada 2 horas 


### Bibliotecas usadas 
Lista de bibliotecas usadas nesse projeto.
- [Newtonsoft.Json](https://github.com/BcryptNet/bcrypt.net)
- [coverlet.collector](https://github.com/coverlet-coverage/coverlet)
- [FluentAssertions](https://fluentassertions.com)
- [Microsoft.AspNetCore.Core](https://dotnet.microsoft.com/en-us/apps/aspnet)
- [Microsoft.AspNetCore.Authentication.JwtBearer](https://dotnet.microsoft.com/en-us/apps/aspnet)
- [Microsoft.EntityFrameworkCore.InMemory](https://dotnet.microsoft.com/en-us/apps/aspnet)
- [Microsoft.NET.Test.Sdk](https://github.com/microsoft/vstest/)
- [Newtonsoft.Json](https://www.newtonsoft.com/json)
- [NPOI](https://github.com/nissl-lab/npoi)
- [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [System.Data.SqlClient](https://github.com/dotnet/corefx)
- [xunit](https://github.com/xunit/xunit)
- [xunit.runner.visualstudio](https://github.com/xunit/visualstudio.xunit)

