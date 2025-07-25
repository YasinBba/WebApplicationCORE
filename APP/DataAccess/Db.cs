﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APP.DataAccess
{
    public class Db : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public Db(DbContextOptions options) : base(options)
        {
        }
    }
}
