using System.Collections.Generic;

namespace APP.DataAccess
{
    public class Db : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
