using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_Srk
{
    public class Grade : Student , IMarks
    {
        public int TeluguMarks { get; set; }
        public int EnglishMarks { get; set; }
        public int HindhiMarks { get ; set; }
        public int MathsMarks { get ; set; }
         public double TotalMarks { get ; set; }

        public void CalculateGrade()
        {
            GetInformation();
            double avgMarks; 
            Console.WriteLine("Enter telugu Marks:");
            TeluguMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter English Marks:");
            EnglishMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hindhi  Marks:");
            HindhiMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maths Marks:");
            MathsMarks = Convert.ToInt32(Console.ReadLine());
            TotalMarks = TeluguMarks + EnglishMarks + HindhiMarks + MathsMarks;
            Console.WriteLine("TotalMarks marks is :" + TotalMarks);
            avgMarks = TotalMarks / 4;
            Console.WriteLine("the avg marks is :"+avgMarks);
            if (avgMarks ==400)
            {
                Console.WriteLine("the student grade is 'A' ");
            }
            else if(avgMarks <=300 && avgMarks >=200)
            {
                Console.WriteLine("The student grade is 'B' ");
            }
            else
            {
                Console.WriteLine("the student grade is 'C'");
            }
            Console.ReadLine();


        }
    }
}
