namespace Assignment03
{
    public class PrintedBook : Book
    {
        public int PageCount { get; set; } // Number of pages

        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)  // Call base class constructor
        {
            PageCount = pageCount;
        }

        // Override DisplayInfo to include page count
        public override void DisplayInfo()
        {
            base.DisplayInfo();  // Call base class DisplayInfo
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
