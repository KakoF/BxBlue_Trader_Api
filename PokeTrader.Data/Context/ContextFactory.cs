using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeTrader.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
       
        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            return new MyContext(optionsBuilder.Options);

        }
    }
}