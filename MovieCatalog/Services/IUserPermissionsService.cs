using MovieCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.Services
{
	public interface IUserPermissionsService
	{
		Boolean IsAuthenticated();
		Boolean CanEditMovie(Movie movie);
	}
}
