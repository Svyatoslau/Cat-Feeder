using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model1
{
    public interface IFirstPageService
    {
        event Action UserEvent;
        void createCustormer(string login, string password);
        void createAdmin(string login, string password);
    }
}
