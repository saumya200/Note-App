// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace NoteApp
{
    class Program
    {
        static List<string> notes = new List<string>();
        static void Main(string[] args)
        {
            while(true)
            {
                System.Console.WriteLine("\nNote App");
                System.Console.WriteLine("1. Add a note");
                System.Console.WriteLine("2. View notes");
                System.Console.WriteLine("3.Exit");
                System.Console.Write("Choose an option:");
                string choice =  Console.ReadLine();

                switch(choice)
                {
                    case "1":
                     AddNote();
                     break;
                     case "2":
                     ViewNote();
                     break;
                     case "3":
                     return;
                     default:
                     System.Console.WriteLine("Invalid choice, please try again");
                     break;
                }
            }

        }
        static void AddNote(){
            System.Console.WriteLine("Enter your note:");
            string note = Console.ReadLine();
            notes.Add(note);
            System.Console.WriteLine("Note Added!");
            
        }

        static void ViewNote(){
            System.Console.WriteLine("View your notes:");
            if(notes.Count ==  0){
                System.Console.WriteLine("No notes available!");
            }
            else{
                for(int i  = 0; i< notes.Count ; i++){
                    Console.WriteLine($"{i+1}, {notes[i]}");
                }
            }
        }
    }
}