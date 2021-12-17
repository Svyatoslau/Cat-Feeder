using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model1;
using Model.Ententity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class UserRepository : IRepository<Customer>
    {
        public int Add(Customer obj)
        {
            throw new NotImplementedException();
        }

        public Customer Find(string name)
        {
            MySqlCommand cmd = null;
            Customer customer = null;
            string query = "SELECT * FROM signintutorial.users where userName = (@username) limit 1";
            cmd = DBHelper.RunQuery(query, name);

            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer obj)
        {
            throw new NotImplementedException();
        }
        
    }

}
