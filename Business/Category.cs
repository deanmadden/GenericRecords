using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Business
{
    /// <summary>
    /// Category
    /// </summary>
    [DataContract]
    public class Category
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime Created { get; set; }

        public Category()
        {

        }

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
        [DataMember]
        public List<string> Fields { get; set; }

    }
}
