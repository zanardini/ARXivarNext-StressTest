namespace BackOfficeFramework
{
    public interface IArxivarService
    {
        IO.Swagger.Client.Configuration Configuration { get; }
        void Login();
    }    
}
