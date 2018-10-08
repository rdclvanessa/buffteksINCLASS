using System;

namespace buffteks2
{
    public class Student
    {
        //PK
        public int StudentID{get; set;}
        //First Name
        public string FName{get;set;}
        //Last Name
        public string LName{get;set;}
        //phone
        public string Phone{get;set;}
        //email
        public string Email{get;set;}
        //Role
        public string Role{get;set;}
        
        public override string ToString()
        {
            return this.FName + " " + this.LName;
        }
    }
}