using System;

namespace Api_LoginMvc.Dto
{
    public class ResultadoCadastroUsuarioDto
    {

        public ResultadoCadastroUsuarioDto(Guid id, DateTime created, DateTime modified, DateTime last_login, string nome, string sobreNome,
                                            string email, string telefone)
        {
            Id = id;
            Created = created;
            Modified = modified;
            LastLogin = last_login;
            Profiles = new Profiles
            {
                Nome = nome,
                Email = email,
                SobreNome = sobreNome,
                Telefone = telefone

            };
        }

        public Guid Id { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastLogin { get; set; }
        public Profiles Profiles { get; set; }

    }
}
