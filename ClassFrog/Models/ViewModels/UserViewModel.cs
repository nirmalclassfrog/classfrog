using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassFrog.Models.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets my classes.
        /// </summary>
        /// <value>
        /// My classes.
        /// </value>
        public IList<ClassViewModel> MyClasses { get; set; }

        /// <summary>
        /// Gets or sets the dropped classes.
        /// </summary>
        /// <value>
        /// The dropped classes.
        /// </value>
        public IList<ClassViewModel> DroppedClasses { get; set; }
    }
}