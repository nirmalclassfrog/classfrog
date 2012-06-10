using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassFrog.Repositories.Interfaces;

namespace ClassFrog.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public void Register(Models.ViewModels.UserViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the specified user id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        public Models.ViewModels.UserViewModel Get(string userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether the specified model is authenticated.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        ///   <c>true</c> if the specified model is authenticated; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAuthenticated(Models.ViewModels.UserViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}