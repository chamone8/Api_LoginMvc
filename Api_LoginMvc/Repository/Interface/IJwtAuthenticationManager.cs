namespace Api_LoginMvc
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string usuario, string senha);
    }
}
