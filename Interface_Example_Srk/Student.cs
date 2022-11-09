using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_Srk
{
    public class Student
    {
       public  int studentId;
         public string studentName;
       public  String studentAddress;
        public String studentSection;

        public void GetInformation()
        {
            Console.WriteLine("Enter student Id:");
            studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name:");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter student Address:");
            studentAddress = Console.ReadLine();
            Console.WriteLine("Enter student Section:");
            studentSection = Console.ReadLine();
            Console.ReadLine();   
            ShowInformation();
        }
        public void ShowInformation()
        {
            Console.WriteLine("Student id is:" + studentId);
            Console.WriteLine("Student name  is:" + studentName);
            Console.WriteLine("Student id is:" + studentAddress);
            Console.WriteLine("Student id is:" + studentSection);

        }
    }
}
