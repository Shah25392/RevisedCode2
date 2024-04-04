using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Runtime.CompilerServices;

using System.Xml.Linq;

namespace Assessment2Task2

{

    class Prog

    {

        public static void AddRooms()

        {

            int addrooms;

            Console.WriteLine("");

            addrooms = Convert.ToInt32(Console.ReadLine());

            if (addrooms <= 10)

            {

                for (int i = 0; i < addrooms; i++)

                {

                    string[] room = ["105", "106", "107", "108", "109", "110", "111"];

                    Console.WriteLine(room[i] + "");

                    Console.WriteLine($"Room" + i + 1);

                    Console.WriteLine("Enter room type");

                    int roomOfType = Convert.ToInt32(Console.ReadLine());

                    string[] roomType = ["Non AC Single Room", "AC Single Room", "Non AC Double Room", "AC Double Room"];

                    Console.Write(roomType[i] + "");

                    Console.WriteLine($"Room number " + room[i] + " of type " + roomType[i] + " added successfully");

                }

            }

            else { Console.WriteLine("Invalid Input"); }

        }

        public static void DisplayRooms()

        {

            int roomNumber = Convert.ToInt32(Console.ReadLine());

            string roomType = Console.ReadLine();

            Console.Write("Your choices are:");

            Console.WriteLine($"Room Number is : " + roomNumber);

            Console.WriteLine($"Room Type is :" + roomType);

        }

        public static void AllocateRooms()

        {

            Console.WriteLine("Allocate Room");

            Console.ReadLine();

            Console.Write("Enter guest name : ");

            string guestName = Console.ReadLine();

            Console.Write("Enter Room Number");

            int roomNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Room Number" + roomNumber + "is allocated to" + guestName);

        }

        public static void DeAllocateRooms()

        {

            Console.WriteLine("De-Allocate Room");

            Console.ReadLine();

            Console.Write("Enter guest name : ");

            string guestName = Console.ReadLine();

            Console.Write("Enter Room Number");

            int roomNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Room Number" + roomNumber + "De-allocated to" + guestName);

        }

        public static void DisplayRoomAllocationDetails()

        {

            Console.WriteLine("");

        }

        public static void Billing()

        {

            Console.WriteLine("Billing Feature is under Construction and will be added soon");

        }

        public static void SaveTheRoomAllocationToFile()

        {

            string filepath = @"C:\Users\nawaz\source\Rooms\lhms_850000716.txt";

            if (File.Exists(filepath))

            {

            }

        }

        public static void showtheRoomAllocationFromTheRoom()

        {

            Console.Write("");

        }


        public static void BackupMenu()

        {

        }

        static void Main(string[] args)

        {

            FileStream fs = new FileStream("C:\\Users\\nawaz\\source\\Rooms\\lhms_850000716.txt'", FileMode.Create);

            fs.Close();

            Console.WriteLine("File has been created");


            char answer;
            bool exit = false;


            while (!exit)
            {

                Console.Clear();

                Console.WriteLine("--------------------------------------------------------");

                Console.WriteLine("LANGHAM HOTEL MANAGEMENT SYSTEM");

                Console.WriteLine("MENU");

                Console.WriteLine("--------------------------------------------------------");

                Console.WriteLine("1.Add Rooms");

                Console.WriteLine("2.Display Rooms");

                Console.WriteLine("3.Allocate Rooms");

                Console.WriteLine("4.De-Allocate Rooms");

                Console.WriteLine("5.Display Room Allocation Detalis");

                Console.WriteLine("6.Billing");

                Console.WriteLine("7.Save the Room Allocattions to a file");

                Console.WriteLine("8.Show the Room Allocations From a File");

                Console.WriteLine("9.Exit");

                Console.WriteLine("0. Backup");

                Console.Write("Enter Your Choice Number Here: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)

                {

                    case 1: AddRooms(); break;

                    case 2: DisplayRooms(); break;

                    case 3: AllocateRooms(); break;

                    case 4: DeAllocateRooms(); break;

                    case 5: DeAllocateRooms(); break;

                    case 6: Billing(); break;

                    case 7: SaveTheRoomAllocationToFile(); break;

                    case 8: showtheRoomAllocationFromTheRoom(); break;

                    case 9:
                        Console.WriteLine("You have successfully Exited."); 
                        exit = true;
                        break;

                    case 10: BackupMenu(); break;

                    default: Console.WriteLine("Invalid input"); break;

                }

                Console.WriteLine("Would you like to continue(Y or N)");

                answer = Convert.ToChar(value: Console.ReadLine());

                if (answer == 'Y' || answer == 'y')  
                {
                    exit = true;
                }

            }

        }

    }

}