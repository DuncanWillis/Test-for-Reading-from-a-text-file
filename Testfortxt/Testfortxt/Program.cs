using System;

namespace Testfortxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"\Users\Duncan\Desktop\Mac Visual Studio C#\Projects\Personal Practise\Testfortxt\textFile.txt");
            Console.WriteLine("The textfile contains the following text: {0}", text);
            Console.ReadKey();

            //it seems to be that for the reading of a file to work on a Mac, you have to explicitly write the location using normal spaces
        }
    }
}
