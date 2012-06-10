using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using ClassFrog.Models.Enumerations;

namespace ClassFrog.Models.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class ClassViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Title { get; set; }
        
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the class URL.
        /// </summary>
        /// <value>
        /// The class URL.
        /// </value>
        public Uri ClassUrl { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [participatein discussion].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [participatein discussion]; otherwise, <c>false</c>.
        /// </value>
        public bool ParticipateinDiscussion { get; set; }

        /// <summary>
        /// Gets or sets the class photo.
        /// </summary>
        /// <value>
        /// The class photo.
        /// </value>
        public Image ClassPhoto { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [pre requisites].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [pre requisites]; otherwise, <c>false</c>.
        /// </value>
        public bool PreRequisites { get; set; }

        /// <summary>
        /// Gets or sets the required books.
        /// </summary>
        /// <value>
        /// The required books.
        /// </value>
        public List<string> RequiredBooks { get; set; }

        /// <summary>
        /// Gets or sets the class status.
        /// </summary>
        /// <value>
        /// The class status.
        /// </value>
        public EnumClassStatus ClassStatus { get; set; }
    }
}