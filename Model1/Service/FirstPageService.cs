using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;
using DAL;

namespace Model1.Service
{
    public class FirstPageService : IFirstPageService
    {
        public event Action UserEvent;
        
        public void createCustormer(string login, string password)
        {
            UserRepository _repository = new UserRepository();
            Customer PretenderCustomer = new Customer(login, password, "user");

            



            UserEvent?.Invoke();
        }

        public void createAdmin(string login, string password)
        {
            UserRepository _repository = new UserRepository();
            Customer PretenderCustomer = new Customer(login, password, "admin");

            UserEvent?.Invoke();
        }


    }
}
