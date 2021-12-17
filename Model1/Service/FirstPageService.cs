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
            Random random = new Random();
            int ID = random.Next(0, 10000);

            Customer customer = new Customer(ID, login, password, "admin");

            UserEvent?.Invoke();
        }


    }
}
