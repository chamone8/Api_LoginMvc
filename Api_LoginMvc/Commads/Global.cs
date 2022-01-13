using Api_LoginMvc.Model;
using System.Collections.Generic;

namespace Api_LoginMvc.Common
{
    public static class Global
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
