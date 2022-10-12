using System;
using System.Collections.Generic;
using System.Text;

namespace PartyCommentLibrary.Model
{
    public class CommentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string YourCity { get; set; }
        public string YourComment { get; set; }
       

        public string PartyInfo
        {
            get { return $"Hi, I am {FirstName} {LastName} and I Live in {YourCity}. I would like to say that the Party was {YourComment}"; }              
                    
                    
                    
                    
                     
           
        }



    }
}
