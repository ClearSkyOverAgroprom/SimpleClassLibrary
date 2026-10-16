
using _0203ClassLibrary;

namespace ClassLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager.WriteContentJson(@"C:\Users\johannes daniels\Desktop\grop.txt", "chabos wissen wer 123der babo ist");
            Console.WriteLine(FileManager.GetContentJson(@"C:\Users\johannes daniels\Desktop\grop.txt"));

        }
    }
}