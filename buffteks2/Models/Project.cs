using System;

namespace buffteks2
{
    public class Project
    {
        //PK
        public int ProjectID{get; set;}
        //name
        public string Name{get; set;}
        //leader = FK team lead
        public string TeamLead{get; set;}
        //required hours
        public int Hours{get; set;}
        //client = FK client
        public string Client{get; set;}
        //deadline = DateTime
        public DateTime Deadline{get; set;}

        public override string ToString()
        {
            return this.Name + " " + this.TeamLead;
        } 
    }
}