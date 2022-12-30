using GProject.Api.Models;

namespace GProject.Api.MyServices.IServices
{
    public interface ILoginService
    {
        public UserModel Login(string email, string pass);
    }
}
