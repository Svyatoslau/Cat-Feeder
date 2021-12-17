using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace Model1.Service
{
    public class FirstPageService : IFirstPageService
    {
        public void Connection()
        {
            DBHelper.EstablishConnection();
        }
    }
}
