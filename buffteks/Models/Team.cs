using System;

namespace buffteks.Models
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
    }
}