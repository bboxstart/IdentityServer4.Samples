namespace Api.Models
{
    /// <summary>
    /// Book model for use in API methods
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Author of the book
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }
    }
}
