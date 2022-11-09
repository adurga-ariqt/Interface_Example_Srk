using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_Srk
{
    public  interface IMarks
    {
        public int TeluguMarks { get; set; }
        public int EnglishMarks { get; set; }
        public int HindhiMarks { get; set; }
        public int MathsMarks{ get; set; }
        public double TotalMarks { get; set; }
        void CalculateGrade();

    }
}
