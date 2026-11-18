using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Given int pages = 464;, write an if / else statement that prints
            //"Long Book" if pages is greater than
            //300, otherwise prints "Short Book".

            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            #endregion

            #region Q02
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.Use the && operator.

            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Q03
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            #endregion

            #region Q04
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            //variable sizeLabel(same rule as question 8: long if pages > 300).

            //int pages = 464;
            //string sizelabel = (pages > 300) ? "Long book" : "short book";
            //Console.WriteLine(sizelabel);
            #endregion

            #region Q05
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            //to print each book with its position number, like 1.Clean Code

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; ++i)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion

            #region Q06
            //Using the same books array, use a while loop to print every book title.
            //int size = books.Length;
            //int i = 0;
            //while(i < size)
            //{
            //    Console.WriteLine(books[i]);
            //    ++i;
            //}
            #endregion

            #region Q07
            // Write a do-while loop that prints "Checking book..." exactly 3 times.
            int i = 0;
            do
            {
                Console.WriteLine(books[i]);
                ++i;
            } while (i < 3);

            #endregion
        }
    }
}
