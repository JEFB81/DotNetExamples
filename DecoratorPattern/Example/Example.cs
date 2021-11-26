using System;

namespace DecoratorPattern.Example
{
    public static class Example
    {
        public static void Start() 
        {
            // Create book
            var book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
            // Create video
            var video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");
            var borrowVideo = new Borrowable(video);
            borrowVideo.BorrowItem("Customer #1");
            borrowVideo.BorrowItem("Customer #2");
            borrowVideo.Display();

            // Make book borrowable, then borrow and display
            var borrowBook = new Borrowable(book);
            borrowBook.BorrowItem("Customer #3");
            borrowBook.Display();

            // Maak video reorder, then order item and Display
            var reorderVideo = new Reorder(video);
            reorderVideo.OrderItem("Jaws");
            reorderVideo.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
