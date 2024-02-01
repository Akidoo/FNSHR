using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FNSHR.Data
{
	public class dataContext : IdentityDbContext
	{
		public dataContext(DbContextOptions options) : base(options)
		{


		}
	}
}

