using System;
using System.Collections.Generic;

namespace Business
{
    /// <summary>
    /// Category
    /// </summary>
    public class Category
    {
        public string Name { get; }

        public DateTime Created { get; }

        public Category(string name)
        {
            Name = name;
            Fields = new List<string>();
            Created = DateTime.Now;
        }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public List<string> Fields { get; set; }

    }
}
