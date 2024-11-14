using System;
using System.ComponentModel.Design;
namespace tävling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 16 && ålder <= 19)
                Console.WriteLine("Du får vara med och delta i tävlingen");
            else if (ålder < 16)
                Console.WriteLine("Du är för ung för att delta");
            
            else Console.WriteLine(" Du är för gammal för att delta");
        }
    }
}