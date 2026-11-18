using System.Drawing;

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

            int pages = 464;
            bool isAvailable = true;

            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion
        }
    }
}
