using System;
using System.Threading;
using static CGS.Function;

namespace CGS
{
    class Program
    {
        static void Main(string[] args)
        {
            string task;
            do
            {
                Menu();
                Console.Write("Enter your number of task: ");
                task = Console.ReadLine();
                switch (task)
                {
                    case "1":
                        AddArtist();
                        break;
                    case "2":
                        AddCurator();
                        break;
                    case "3":
                        AddArtPiece();
                        break;
                    case "4":
                        DisplayAllArtPieces();
                        break;
                    case "5":
                        Console.Write("Enter Code : ");
                        string code = Console.ReadLine();
                        FindArtPieceByCode(code);
                        break;
                    case "6":
                        Console.Write("Enter Code : ");
                        string artPieceCode = Console.ReadLine();
                        DeleteArtPieceByCode(artPieceCode);
                        break;
                    case "7":
                        Console.WriteLine("Quiting Applicaion...");
                        break;
                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
                Thread.Sleep(2000);
            } while (task != "7");
        }

        static void Menu()
        {
            Console.WriteLine("1. Add an artist");
            Console.WriteLine("2. Add a curator");
            Console.WriteLine("3. Add an art piece");
            Console.WriteLine("4. Display all art pieces");
            Console.WriteLine("5. Find an art piece by code");
            Console.WriteLine("6. Delete an art piece");
            Console.WriteLine("7. Quit the application");
            Console.WriteLine("");
        }
    }
}
