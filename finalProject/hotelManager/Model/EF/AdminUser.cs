using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    class AdminUser
    {
        public int Id { get; set; }
        public String Account { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
    }
}
