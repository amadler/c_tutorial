using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighiestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public float HighiestGrade;
        public float LowestGrade;
        public float AverangeGrade;
    }
}
