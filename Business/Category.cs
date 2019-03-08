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
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        [DataMember]
        public DateTime Created { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
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
