using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Ententity;
using System.Windows.Forms;

namespace Model1.Service
{
    public class AdminRegFormService : IAdminRegFormService
    {
        public event Action UserRegistered;
        public IRepository<Customer> _customer;
        private Customer customer;
        private Customer Testcustomer;

        public AdminRegFormService(IRepository<Customer> customer)
        {
            _customer = customer;
        }
        public void AddUser(string login, string password)
        {
            //проверяем есть ли такой логин пользователя
            customer = _customer.Find(login);
            if(customer == null)
            {
                customer = new Customer(login, password, "user");
                //добавляем объект пользователя в бд
                _customer.Add(customer);

                //проверка добавления полователя
                Testcustomer = _customer.Find(login);
                if (Testcustomer != null)
                {
                    if (Testcustomer.Password.Equals(password))
                    {
                        
                        if (customer.Status.Equals("user"))
                        {
                            MessageBox.Show("New user created successfully");
                            UserRegistered?.Invoke();
                        }

                    }
                    else
                    {
                        MessageBox.Show("New user has not been created");
                    }
                } else
                {
                    MessageBox.Show("New user has not been created");
                }

            } else
            {
                MessageBox.Show("User with this login already exists");
            }

        }
    }
}
