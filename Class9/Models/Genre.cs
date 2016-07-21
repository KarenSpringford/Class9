using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class9.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        /// 
        public Genre()
        {

        }

        /// <summary>
        /// This consturcotr takes one parameter - Name
        /// </summary>
        /// 
        public Genre (string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }
}