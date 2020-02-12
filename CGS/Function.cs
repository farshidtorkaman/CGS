using System;
using CGS.Persistence;
using static CGS.Persistence.Data;
using static CGS.Validations.ArtPieceValidation;
using CGS.Validations;

namespace CGS
{
    public class Function
    {
        public static void AddArtist()
        {
            if (ArtistCount < 5)
            {
                bool condition;

                string ID;
                do
                {
                    Console.Write("Enter Artist ID: ");
                    ID = Console.ReadLine();
                    condition = ArtistValidation.IsIdValid(ID);
                    if (!condition)
                        Console.WriteLine("ID is not valid (Enter 5 Unique character)");
                } while (!condition);

                string fname;
                do
                {
                    Console.Write("Enter Artist First Name: ");
                    fname = Console.ReadLine();
                    condition = ArtistValidation.IsNameValid(fname);
                    if (!condition)
                        Console.WriteLine("First name should be at most 40 character");
                } while (!condition);

                string lname;
                do
                {
                    Console.Write("Enter Artist Last Name: ");
                    lname = Console.ReadLine();
                    condition = ArtistValidation.IsNameValid(lname);
                    if (!condition)
                        Console.WriteLine("Last name should be at most 40 character");
                } while (!condition);

                MyArtists[ArtistCount].ID = ID;
                MyArtists[ArtistCount].fname = fname;
                MyArtists[ArtistCount].lname = lname;
                Console.WriteLine("Artist Added Succesfully");
                Console.WriteLine("");
                Console.WriteLine("");
                Data.ArtistCount++;
            }
            else
            {
                Console.WriteLine("you can not add anymore artist");
            }
        }

        public static void AddCurator()
        {
            if (CuratorCount < 3)
            {
                bool condition;

                string ID;
                do
                {
                    Console.Write("Enter Curator ID: ");
                    ID = Console.ReadLine();
                    condition = CuratorValidation.IsIdValid(ID);
                    if (!condition)
                        Console.WriteLine("ID is not valid (Enter 5 Unique character)");
                } while (!condition);

                string fname;
                do
                {
                    Console.Write("Enter Curator First Name: ");
                    fname = Console.ReadLine();
                    condition = CuratorValidation.IsNameValid(fname);
                    if (!condition)
                        Console.WriteLine("first name should be at most 40 character");
                } while (!condition);

                string lname;
                do
                {
                    Console.Write("Enter Curator Last Name: ");
                    lname = Console.ReadLine();
                    condition = CuratorValidation.IsNameValid(lname);
                    if (!condition)
                        Console.WriteLine("Last name should be at most 40 character");
                } while (!condition);

                Data.MyCurators[CuratorCount].ID = ID;
                Data.MyCurators[CuratorCount].fname = fname;
                Data.MyCurators[CuratorCount].lname = lname;
                Console.WriteLine("Curator Added Succesfully");
                Console.WriteLine("");
                Console.WriteLine("");
                CuratorCount++;
            }
            else
            {
                Console.WriteLine("You can not add anymore curator");
            }
        }

        public static void AddArtPiece()
        {
            try
            {
                if (ArtPieceCount < 10)
                {
                    bool condition;

                    string ID;
                    do
                    {
                        Console.Write("Enter ID: ");
                        ID = Console.ReadLine();
                        condition = ArtPieceValidation.IsIdValid(ID);
                        if (!condition)
                            Console.WriteLine("ID is not valid (Enter 5 Unique character)");
                    } while (!condition);

                    string title;
                    do
                    {
                        Console.Write("Enter the title: ");
                        title = Console.ReadLine();
                        condition = IsTitleValid(title);
                        if (!condition)
                            Console.WriteLine("Title should be at most 40 character");
                    } while (!condition);

                    string date;
                    do
                    {
                        Console.Write("Enter the date in year: ");
                        date = Console.ReadLine();
                        condition = IsDateValid(date);
                        if (!condition)
                            Console.WriteLine("Date must be 4 digits");
                    } while (!condition);

                    string IDArtist;
                    do
                    {
                        Console.Write("Enter artist ID: ");
                        IDArtist = Console.ReadLine();
                        condition = ArtPieceValidation.IsArtistIdValid(IDArtist);
                        if (!condition)
                        {
                            Console.WriteLine("Id Artist does not exist");
                            string response;
                            do
                            {
                                Console.Write("do you want to add this artist? (y/n): ");
                                response = Console.ReadLine();
                                if (response == "y" || response == "Y")
                                {
                                    AddArtist();
                                }
                                else if (response == "n" || response == "N")
                                {
                                    throw new Exception();
                                }
                                else
                                {
                                    Console.WriteLine("invalid response");
                                }
                            } while (!(response == "y" || response == "Y" || response == "n" || response == "N"));
                        }
                    } while (!condition);

                    string IDCurator;
                    do
                    {
                        Console.Write("Enter curator ID: ");
                        IDCurator = Console.ReadLine();
                        condition = ArtPieceValidation.IsCuratorIdValid(IDCurator);
                        if (!condition)
                        {
                            Console.WriteLine("Id Curator does not exist");
                            string response;
                            do
                            {
                                Console.Write("do you want to add this curator? (y/n): ");
                                response = Console.ReadLine();
                                if (response == "y" || response == "Y")
                                {
                                    AddCurator();
                                }
                                else if (response == "n" || response == "N")
                                {
                                    throw new Exception();
                                }
                                else
                                {
                                    Console.WriteLine("invalid response");
                                }
                            } while (!(response == "y" || response == "Y" || response == "n" || response == "N"));
                        }
                    } while (!condition);

                    string estimed;
                    do
                    {
                        Console.Write("Enter Estimated Price: ");
                        estimed = Console.ReadLine();
                        condition = IsEstimedAndPriceValid(estimed);
                        if (!condition)
                            Console.WriteLine("Estimated Price must be digits");
                    } while (!condition);

                    string price;
                    do
                    {
                        Console.Write("Enter the Price of the Art Piece: ");
                        price = Console.ReadLine();
                        condition = IsEstimedAndPriceValid(price);
                        if (!condition)
                            Console.WriteLine("Price must be digits");
                    } while (!condition);

                    string status;
                    do
                    {
                        Console.Write("Enter the status: (You Should Enter --> D: Print pieces on display -- S: Print Sold Pieces -- O: Print pices in Storage\n");
                        status = Console.ReadLine();
                        condition = IsStatusValid(status);
                        if (!condition)
                            Console.WriteLine("Status should be D or S or O");
                    } while (!condition);

                    Data.MyArtPieces[ArtPieceCount].ID = ID;
                    Data.MyArtPieces[ArtPieceCount].title = title;
                    Data.MyArtPieces[ArtPieceCount].date = date;
                    Data.MyArtPieces[ArtPieceCount].IDArtist = IDArtist;
                    Data.MyArtPieces[ArtPieceCount].IDCurator = IDCurator;
                    Data.MyArtPieces[ArtPieceCount].estimed = double.Parse(estimed == "" ? "0" : estimed);
                    Data.MyArtPieces[ArtPieceCount].price = double.Parse(price == "" ? "0" : price);
                    Data.MyArtPieces[ArtPieceCount].status = char.Parse(status);
                    Console.WriteLine("Art Piece Added Succesfully");

                    ArtPieceCount++;
                }
                else
                {
                    Console.WriteLine("You can not add anymore art piece");
                }
            }
            catch
            {
            }
        }

        public static void DisplayAllArtPieces()
        {
            var arttt = Data.MyArtPieces;
            bool isEmpty = true;
            for (int i = 0; i < Data.MyArtPieces.Length; i++)
            {
                var ArtPieces = Data.MyArtPieces[i];
                if (ArtPieces.ID != null)
                {
                    isEmpty = false;
                    Console.WriteLine($"ID = {ArtPieces.ID}, title = {ArtPieces.title}, date = {ArtPieces.date}, IDArtist = {ArtPieces.IDArtist}, IDCurator = {ArtPieces.IDCurator}, estimed = {ArtPieces.estimed}, price = {ArtPieces.price}, status = {ArtPieces.status}");
                }
            }
            if (isEmpty)
                Console.WriteLine("No Art Pieces has been added");
        }

        public static void FindArtPieceByCode(string code)
        {
            bool isExist = false;
            for (int i = 0; i < Data.MyArtPieces.Length; i++)
            {
                var ArtPieces = Data.MyArtPieces[i];
                if (ArtPieces.ID == code)
                {
                    isExist = true;
                    Console.WriteLine($"ID = {ArtPieces.ID}, title = {ArtPieces.title}, date = {ArtPieces.date}, IDArtist = {ArtPieces.IDArtist}, IDCurator = {ArtPieces.IDCurator}, estimed = {ArtPieces.estimed}, price = {ArtPieces.price}, status = {ArtPieces.status}");
                }
            }
            if (!isExist)
                Console.WriteLine("Not Found!");
        }

        public static void DeleteArtPieceByCode(string code)
        {
            bool isExist = false;
            for (int i = 0; i < Data.MyArtPieces.Length; i++)
            {
                if (Data.MyArtPieces[i].ID == code)
                {
                    isExist = true;
                    Data.MyArtPieces[i].ID = null;
                    Data.MyArtPieces[i].title = null;
                    Data.MyArtPieces[i].date = null;
                    Data.MyArtPieces[i].IDArtist = null;
                    Data.MyArtPieces[i].IDCurator = null;
                    Data.MyArtPieces[i].estimed = 0;
                    Data.MyArtPieces[i].price = 0;
                    Data.MyArtPieces[i].status = '\0';

                    Console.WriteLine("Succesfully Deleted");
                }
            }
            if (!isExist)
                Console.WriteLine("Not Found!");
        }
    }
}