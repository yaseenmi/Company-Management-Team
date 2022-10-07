using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2___Project1
{
    public class Position
    {
        public bool PositionName;
        public string LetterGrade;
        public decimal MaxSalary;
        public decimal MinSalary;
        public Position (bool PositionName , string LetterGrade , decimal MaxSalary , decimal MinSalary)
        {
            this.PositionName = PositionName;
            this.LetterGrade = LetterGrade;
            this.MaxSalary = MaxSalary;
            this.MinSalary = MinSalary;
        }
    }
}
