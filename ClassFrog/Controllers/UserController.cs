using System.Web.Mvc;
using ClassFrog.Models.ViewModels;
using ClassFrog.Repositories.Interfaces;

namespace ClassFrog.Controllers
{
    /// <summary>
    /// Actions for all user related activities
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// backing for user repository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="userRepository">The user repository.</param>
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        /// Indexes the specified user name.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>ViewResult for getting user page</returns>
        [HttpGet]
        public ActionResult Index(string userName)
        {
            var model = userRepository.Get(userName);
            return View();
        }

        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public ActionResult Register(UserViewModel model)
        {
            userRepository.Register(model);
            return View();
        }
    }
}
