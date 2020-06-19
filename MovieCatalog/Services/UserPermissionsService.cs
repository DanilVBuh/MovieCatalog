using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MovieCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCatalog.Services
{
    public class UserPermissionsService : IUserPermissionsService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<ApplicationUser> userManager;

        public UserPermissionsService(IHttpContextAccessor httpContextAccessor, UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
            this.httpContextAccessor = httpContextAccessor;
        }

        private HttpContext HttpContext => this.httpContextAccessor.HttpContext;

        public Boolean IsAuthenticated()
        {
            if (!this.HttpContext.User.Identity.IsAuthenticated)
            {
                return false;
            }

            return true;
        }

        public Boolean CanEditMovie(Movie movie)
        {
            if (!this.HttpContext.User.Identity.IsAuthenticated)
            {
                return false;
            }

            return this.userManager.GetUserId(this.httpContextAccessor.HttpContext.User) == movie.CreatorId;
        }
    }
}
