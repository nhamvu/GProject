using GProject.Api.Models;
using GProject.Api.MyServices.IServices;
using GProject.Data.DomainClass;
using GProject.Data.MyRepositories.IRepositories;

namespace GProject.Api.MyServices.Services
{
    public class LoginService : ILoginService
    {
        private IEmployeeRepository _iEmployeeRepository;
        private ICustomerRepository _iCustomerRepository;

        public LoginService()
        {
            _iEmployeeRepository = new EmployeeRepository();
            _iCustomerRepository = new CustomerRepository();
        }

        public UserModel Login(string email, string pass)
        {
            UserModel user = null;
            var emp = _iEmployeeRepository.GetAll().FirstOrDefault(c => c.Email == email && c.Password == pass);
            var cus = _iCustomerRepository.GetAll().FirstOrDefault(c => c.Email == email && c.Password == pass);
            if (emp != null)
            {
                user = new UserModel { Email = emp.Email , password = emp.Password, username = emp.Name };
            }
            else if(cus != null)
            {
                user = new UserModel { Email = cus.Email, password = cus.Password, username = cus.Name };
            }
            return user;
        }
    }
}
