using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AdminUserDAO
    {
        HotelContext context = null;
        public AdminUserDAO()
        {
            context = new HotelContext();
        }
        public bool Login (String username, String passwpord)
        {
            int result = context.AdminUsers.Count(x => x.Account == username && x.Password == passwpord);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
