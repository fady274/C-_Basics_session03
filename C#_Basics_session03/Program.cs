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

            int pages = 464;
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion
        }
    }
}
