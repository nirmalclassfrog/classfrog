using ClassFrog.Models.ViewModels;

namespace ClassFrog.Repositories.Interfaces
{
    /// <summary>
    /// User Repositories
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        void Register(UserViewModel model);

        /// <summary>
        /// Gets the specified user id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        UserViewModel Get(string userId);

        /// <summary>
        /// Determines whether the specified model is authenticated.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        ///   <c>true</c> if the specified model is authenticated; otherwise, <c>false</c>.
        /// </returns>
        bool IsAuthenticated(UserViewModel model);
    }
}