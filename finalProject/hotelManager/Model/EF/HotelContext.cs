using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    class HotelContext:DbContext
    {
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
