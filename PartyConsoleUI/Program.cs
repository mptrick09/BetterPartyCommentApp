using PartyCommentLibrary.Model;
using System;
using System.Collections.Generic;

namespace PartyConsoleUI
{
    class Program
    {
        private static List<CommentModel> comments = new List<CommentModel>();
       public static void Main(string[] args)
        {

            GetCommentFromParty();
            PrintPartyComment();




        }




        private static void PrintPartyComment()
        {
            foreach (CommentModel comment in comments)
            {

                Console.WriteLine($"Party Comment: {comment.PartyInfo}.");

            }
        }



        private static void GetCommentFromParty()
        {

            string MoreComment = "";

            do
            {

                CommentModel comment = new CommentModel();

                
                comment.FirstName = GetPartyCommentFromConsole("Enter your First Name");
                
                comment.LastName = GetPartyCommentFromConsole("Enter your Last Name");

                
                comment.YourCity = GetPartyCommentFromConsole("enter your City name");

                
                comment.YourComment = GetPartyCommentFromConsole("What is your Comment today about this Party");

               
                MoreComment = GetPartyCommentFromConsole("Do you want to give your Comment also (yes or No)");

                comments.Add(comment);


                Console.Clear();

            } while (MoreComment.ToLower() == "yes");





        }


        private static string GetPartyCommentFromConsole(string message)
        {
            string output = "";
            Console.WriteLine(message);
            output = Console.ReadLine();
            return output;

        }
    }
}


       
        
        
        
        