using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassFrog.Repositories.Interfaces;

namespace ClassFrog.Repositories
{
    /// <summary>
    /// class details repository
    /// </summary>
    public class ClassRepository : IClassRepository
    {
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public void Create(Models.ViewModels.ClassViewModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public Models.ViewModels.ClassViewModel Get(string className)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the specified class id.
        /// </summary>
        /// <param name="classId">The class id.</param>
        public void Update(string classId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Publishes the specified classs id.
        /// </summary>
        /// <param name="classsId">The classs id.</param>
        public void Publish(string classsId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Flags the specified class id.
        /// </summary>
        /// <param name="classId">The class id.</param>
        public void Flag(string classId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the featured.
        /// </summary>
        /// <returns></returns>
        public IList<Models.ViewModels.ClassViewModel> GetFeatured()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public IList<Models.ViewModels.ClassViewModel> Search(string key)
        {
            throw new NotImplementedException();
        }
    }
}