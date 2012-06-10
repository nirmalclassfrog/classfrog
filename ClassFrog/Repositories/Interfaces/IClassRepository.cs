using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassFrog.Models.ViewModels;

namespace ClassFrog.Repositories.Interfaces
{
    /// <summary>
    /// Class repositories
    /// </summary>
    public interface IClassRepository
    {
        /// <summary>
        /// Creates the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        void Create(ClassViewModel model);
        
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        ClassViewModel Get(string className);

        /// <summary>
        /// Updates the specified class id.
        /// </summary>
        /// <param name="classId">The class id.</param>
        void Update(string classId);

        /// <summary>
        /// Publishes the specified classs id.
        /// </summary>
        /// <param name="classsId">The classs id.</param>
        void Publish(string classsId);

        /// <summary>
        /// Flags the specified class id.
        /// </summary>
        /// <param name="classId">The class id.</param>
        void Flag(string classId);

        /// <summary>
        /// Gets the featured.
        /// </summary>
        /// <returns></returns>
        IList<ClassViewModel> GetFeatured();

        /// <summary>
        /// Searches the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        IList<ClassViewModel> Search(string key);
    }
}