using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassFrog.Repositories.Interfaces;
using ClassFrog.Models.ViewModels;

namespace ClassFrog.Controllers
{
    /// <summary>
    /// Controller class for actions related to class
    /// </summary>
    public class ClassController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IClassRepository classRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassController"/> class.
        /// </summary>
        /// <param name="classRepository">The class repository.</param>
        public ClassController(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(ClassViewModel model)
        {
            classRepository.Create(model);
            return Index(model.Title);
        }

        /// <summary>
        /// Indexes the specified class name.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index(string className)
        {
            var model = classRepository.Get(className);
            return View();
        }

        /// <summary>
        /// Featureds this instance.
        /// </summary>
        /// <returns></returns>
        public ActionResult Catalog()
        {
            var listClasses = classRepository.GetFeatured();
            return View();
        }
    }
}
