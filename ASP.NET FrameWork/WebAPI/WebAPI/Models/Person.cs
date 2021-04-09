using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{/// <summary>
/// specfic person
/// </summary>
    public class Person
    {
        /// <summary>
        /// unique identyfier called id and pk in database
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// giv me your first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Love You 
        /// </summary> 
        public string LastName { get; set; }


    }
}