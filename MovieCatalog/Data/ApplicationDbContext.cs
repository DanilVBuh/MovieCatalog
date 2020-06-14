using Microsoft.EntityFrameworkCore;
using MovieCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options)
			: base(options)
		{

		}

		public DbSet<Movie> Movies { get; set; }

	}
}
