// -----------------------------------------------------------------------
// <copyright file="ClassInstance.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ImportData
{
    using System;
    using System.Collections.Generic;
    using MongoDB.Bson;
    using ClassFrog.Models.ViewModels;
    using ClassFrog.Models.Enumerations;
    

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ClassInstance
    {
        public ClassInstance()
        {

        }

        /// <summary>
        /// News the document.
        /// </summary>
        /// <returns></returns>
        public BsonDocument NewDocument()
        {
            var document = new BsonDocument();
            var model = NewClassViewModel();
            return model.ToBsonDocument();
        }

        /// <summary>
        /// News the user.
        /// </summary>
        /// <returns></returns>
        public BsonDocument NewUser()
        {
            var document = new BsonDocument();
            var model = NewUserViewModel();
            return model.ToBsonDocument();
        }

        /// <summary>
        /// News the class view model.
        /// </summary>
        /// <returns></returns>
        private ClassViewModel NewClassViewModel()
        {
            var model = new ClassViewModel();
            model.Title = "ASP.Net MVC 3" + new Random().Next().ToString();
            model.RequiredBooks = new List<string>();
            model.RequiredBooks.Add("MVC by Nirmal");
            model.Price = 10;
            model.PreRequisites = true;
            model.ParticipateinDiscussion = true;
            model.ClassUrl = new Uri("http://classfrog.com/ASP.NetMVC3");
            model.ClassStatus = EnumClassStatus.Publish;
            model.Description = "This is ASP.Net MVC";
            return model;
        }

        /// <summary>
        /// News the user view model.
        /// </summary>
        /// <returns></returns>
        private UserViewModel NewUserViewModel()
        {
            var model = new UserViewModel();
            model.Name = "Nirmal Selvaraj";
            model.Email = "nirmalselvaraj@gmail.com";
            model.Password = "test";
            model.MyClasses = new List<ClassViewModel>();
            model.MyClasses.Add(NewClassViewModel());
            model.DroppedClasses = new List<ClassViewModel>();
            model.DroppedClasses.Add(NewClassViewModel());
            return model;
        }
    }
}
