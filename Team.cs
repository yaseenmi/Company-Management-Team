using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2___Project1
{
    public class Team
    {
        public  string TeamName;
        public  DateTime creationDate;
        public  string TeamLeader;
        public  List<Employee> TeamMembers = new List<Employee>();
        public Team() { }
        public Team(string TeamName, DateTime CreationDate)
        {
            this.TeamName = TeamName;
            this.creationDate = CreationDate;
        }


        
    }
}
