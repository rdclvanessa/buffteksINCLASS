using System;

namespace buffteks2
{

    public class TeamProject
    {
        public int TeamProjectID{get;set;}
        public int TeamID{get;set;}
        // {
        //     get
        //     {
        //         if (this.TeamID == 3)
        //         {
        //             return 9;
        //         }
        //         else
        //         {
        //             return this.TeamID;
        //         }
        //     } 
        //     set
        //     {

        //     }
            
        //     }
        public Team TheTeam{get; set;}
        public int ProjectID{get; set;}
        public Project TheProject{get; set;}

        public override string ToString()
        {
            return this.TeamID + " " + this.ProjectID;
        }

    }
}