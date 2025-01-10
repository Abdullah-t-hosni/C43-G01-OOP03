namespace Assignment03
{
    public class EBook : Book
    {
        public double FileSize { get; set; } // File size in MB

        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)  // Call base class constructor
        {
            FileSize = fileSize;
        }

        // Override DisplayInfo to include file size
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");
        }
    }
}
