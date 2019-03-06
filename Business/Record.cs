using System.Collections.Specialized;

namespace Business
{
    /// <summary>
    /// Record
    /// </summary>
    public class Record
    {
        /// <summary>
        /// Gets or sets the entries.
        /// </summary>
        /// <value>
        /// The entries.
        /// </value>
        public NameValueCollection Entries { get; set; }

        public Category Category { get; set; }

        public Record(Category category)
        {
            Category = category;
            Entries = new NameValueCollection();

            foreach (var item in category.Fields)
            {
                Entries.Add(item, string.Empty);
            }
        }
    }
}
