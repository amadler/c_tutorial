using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach( float grade in grades )
            {
                stats.HighiestGrade = Math.Max(grade, stats.HighiestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverangeGrade = sum / grades.Count;
            return stats;
        }
        public void AddGrade( float grade)
        {
            grades.Add(grade);
        }
        public string Name;
        List<float> grades;
    }
}
