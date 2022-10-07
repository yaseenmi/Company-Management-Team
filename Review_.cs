using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2___Project1
{
    public class Review_ : Skill0
    {
        public  List<Skill> SetOfEmployeeSkills = new List<Skill>();

        public Review_()
        {

        }
        public   Review_(string Review , List <Skill> SetOfEmployeeSkills , int wight) : base (Review , wight)
        {
            this.SetOfEmployeeSkills = SetOfEmployeeSkills;
        }
    }
}
