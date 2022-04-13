using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BulkyBook.DataAccess
{
	public class ApplicationDbContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
	{
		public ApplicationDbContextFactory()
		{

        }

        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433; Database=BulkyBook; User Id=SA; Password=!Valeria#711");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}

