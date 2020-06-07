﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Northwind.Data.Models;

namespace Northwind.Data
{
    public class SmartDbContextFactory : IDesignTimeDbContextFactory<SmartDbContext>
    {
        public SmartDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SmartDbContext>();
            optionsBuilder.UseSqlServer("Server=.;Database=Northwind;Trusted_Connection=True;");
            return new SmartDbContext(optionsBuilder.Options);
        }
    }
}
