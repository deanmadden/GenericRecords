using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace Business
{
    /// <summary>
    /// Record
    /// </summary>
    public class Record
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets the entries.
        /// </summary>
        /// <value>
        /// The entries.
        /// </value>
        [DataMember]
        public Dictionary<string, string> Entries { get; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        [DataMember]
        public Category Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Record"/> class.
        /// </summary>
        public Record()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Record"/> class.
        /// </summary>
        /// <param name="category">The category.</param>
        public Record(Category category)
        {
            Category = category;
            Entries = new Dictionary<string, string>();

            foreach (var item in category.Fields)
            {
                Entries.Add(item, string.Empty);
            }
        }

        /// <summary>
        /// Adds the entry.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public bool AddEntry(string field, string value)
        {
            if (!Entries.ContainsKey(field))
            {
                // Entry doesn't exist
                return false;
            }
            else
            {
                Entries[field] = value;
                return true;
            }
        }
    }
}
