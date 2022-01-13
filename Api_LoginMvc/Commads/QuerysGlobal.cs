using Api_LoginMvc.Common;
using Api_LoginMvc.Model;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Api_LoginMvc.Commads
{
    public static class QuerysGlobal
    {
        public static bool FindExistingUser(string email)
        {
            Usuario user = Global.Usuarios.SingleOrDefault(x => x.Email == email.ToLower());
            if (user == null)
                return false;

            return true;
        }



    }
}
