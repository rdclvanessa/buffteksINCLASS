using System;
using System.Collections.Generic;
using System.Linq;

namespace buffteks2
{
    class Program
    {
        static void Main(string[] args)
        {

            using(var db = new AppDbContext())
            {
                try 
                {
                //db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                if(!db.Students.Any())
                {
                List<Student> students = new List<Student>()
                {
               new Student()
                {
                    FName = "Jane",
                    LName = "Doe",
                    Phone = "555-555-5555",
                    Email = "JaneD@wtamu.edu",
                    Role = "Junior"
                },
                new Student()
                {
                    FName = "Jeff",
                    LName = "Babb",
                    Phone = "123-555-1234",
                    Email = "asdf@asdf.cds",
                    Role = "Sophmore"
                },
                
                };
                db.Students.AddRange(students);

                db.SaveChanges();
                }
                else
                {
                    var students = db.Students.ToList();

                    var studentsFiltered = students.Where(s => s.FName.Length >= 5);
                    foreach(Student s in students)
                    {
                        Console.WriteLine(s);
                    }
                }

                if(!db.Clients.Any())
                {
                List<Client> clients = new List<Client>()
                {
               new Client()
                {
                    ClientId = 1,
                    FName = "Vanessa",
                    LName = "Valen",
                    Phone = "555-555-5555"
                },

                new Client()
                {
                    ClientId = 2,
                    FName = "Cq",
                    LName = "gu",
                    Phone = "599999955"
                },

                };

                db.Clients.AddRange(clients);

                db.SaveChanges();
                }
                else
                {
                    var clients = db.Clients.ToList();
                    foreach(Client c in clients)
                    {
                        Console.WriteLine(c);
                    }
                }

                if(!db.Projects.Any())
                {
                List<Project> projects = new List<Project>()
                {
               new Project()
                {
                    ProjectID = 1,
                    Name = "Project1",
                    TeamLead = "The Leader",
                    Hours = 4
                },

                new Project()
                {
                    ProjectID = 2,
                    Name = "Project2",
                    TeamLead = "The Lead",
                    Hours = 10
                },

                };

                db.Projects.AddRange(projects);

                db.SaveChanges();
                }
                else
                {
                    var projects = db.Projects.ToList();
                    foreach(Project p in projects)
                    {
                        Console.WriteLine(p);
                    }
                }
                
                if(!db.Teams.Any())
                {
                List<Team> Teams = new List<Team>()
                {
               new Team()
                {
                    TeamID = 21,
                    Name = "Team21"
                },

                new Team()
                {
                    TeamID = 22,
                    Name = "Team22"
                },

                };

                db.Teams.AddRange(Teams);

                db.SaveChanges();
                }
                else
                {
                    var teams = db.Teams.ToList();
                    foreach(Team t in teams)
                    {
                        Console.WriteLine(t);
                    }
                }

                
                if(!db.TeamProjects.Any())
                {
                List<TeamProject> TeamProjects = new List<TeamProject>()
                {
               new TeamProject()
                {
                    TeamProjectID = 1,
                    TeamID = 21,
                    ProjectID = 1
                },

                new TeamProject()
                {
                    TeamProjectID = 2,
                    TeamID = 22,
                    ProjectID = 2
                },

                };

                db.TeamProjects.AddRange(TeamProjects);

                db.SaveChanges();
                }
                else
                {
                    var teamprojects = db.TeamProjects.ToList();
                    foreach(TeamProject tp in teamprojects)
                    {
                        Console.WriteLine(tp);
                    }
                }
                }

                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
        }
    }
}
