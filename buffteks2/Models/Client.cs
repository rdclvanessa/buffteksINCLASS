using System;

namespace buffteks2
{
    public class Client
    {
        //Client ID
        public int ClientId{get;set;}
        //project list
        public int ProjectList{get; set;}
        //id
       // public int ProjectID{get; set;}

        //first name
        public string FName{get; set;}
        //last name
        public string LName{get; set;}
        //phone
        public string Phone{get; set;}
        //email
        public string Email{get; set;}
        //organization
        public string organization{get; set;}
        
        public override string ToString()
        {
            return this.FName + " " + this.LName;
        } 
    }
       
}