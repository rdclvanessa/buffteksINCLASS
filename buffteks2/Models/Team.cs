using System;

namespace buffteks2
{

    public class Team
    {
        //PK
        public int TeamID{get; set;}
        //Student list - FK
        public string StudentList{get; set;}
        //name
        public string Name{get; set;}
        //projects - FK??
        public int ProjectID{get; set;}

        public override string ToString()
        {
            return this.TeamID + " " + this.Name;
        } 
    }
}