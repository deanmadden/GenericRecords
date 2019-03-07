using System.Collections.Specialized;

namespace Business
{
    /// <summary>
    /// Record
    /// </summary>
    public class Record
    {
        /// <summary>
        /// Gets the entries.
        /// </summary>
        /// <value>
        /// The entries.
        /// </value>
        public NameValueCollection Entries { get; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public Category Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Record"/> class.
        /// </summary>
        /// <param name="category">The category.</param>
        public Record(Category category)
        {
            Category = category;
            Entries = new NameValueCollection();

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
            var result = Entries[field];

            if (result == null)
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
