using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DefaultConnection: DbContext
    {
        public DbSet<BusinessEntity> BusinessEntities { get; set; }
    }
}
