using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1.Service
{
    public class FirstPageService : IFirstPageService
    {
        public event Action UserEvent;
        
        public void createCustormer(string login, string password)
        {
            
            UserEvent?.Invoke();
        }

        public void createAdmin(string login, string password)
        {

            UserEvent?.Invoke();
        }


    }
}
