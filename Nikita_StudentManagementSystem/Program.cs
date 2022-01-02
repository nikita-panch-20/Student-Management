using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create Students
            Student student1 = new Student() { Studentid = 001, StudentName = "Abc" };
            Student student2 = new Student() { Studentid = 002, StudentName = "Ras" };
            Student student3 = new Student() { Studentid = 003, StudentName = "qwe" };
            Student student4 = new Student() { Studentid = 004, StudentName = "Rzxc" };
            Student student5 = new Student() { Studentid = 005, StudentName = "iop" };


            //2.Create Branch
            Branch branch1 = new Branch() { Branchid = 101, BranchName = "CSE" };
            Branch branch2 = new Branch() { Branchid = 102, BranchName = "ISE" };
            Branch branch3 = new Branch() { Branchid = 103, BranchName = "EEE" };

            //3.Add students to branch
            branch1.AddStudent(student1);
            branch1.AddStudent(student2);
            branch2.AddStudent(student3);
            branch3.AddStudent(student4);
            branch3.AddStudent(student5);

            //Create Fees
            Fees fee1 = new Fees() { PaidDt = "10-09-2021", Amount = 40000 };
            Fees fee2 = new Fees() { PaidDt = "12-09-2021", Amount = 60000 };



            //4.Add fees to students
            student1.AddFees(fee1);
            student2.AddFees(fee2);
            student3.AddFees(fee1);
            student4.AddFees(fee2);
            student5.AddFees(fee1);

            //5.Create College
            College college = new College() { CollegeID = 1001, CollegeName = "DrAIT" };


            //6.Add branches to college
            college.AddBranch(branch1);
            college.AddBranch(branch2);
            college.AddBranch(branch3);

            //7.Display College info
            DisplayCollegeInfo(college);
        }

        private static void DisplayCollegeInfo(College college)
        {
            double total = 0;

            double count = 0;
            double c = 0;
            Console.WriteLine($"College Info  CollegeID : {college.CollegeID}  CollegeName : {college.CollegeName}");
            DrawLine();
            Console.WriteLine("Branch Info");
            foreach (var branch in college.GetBranches())
            {

                double amount = 0;
                DrawLine();
                Console.WriteLine($"BranchID : {branch.Branchid} BranchName : {branch.BranchName}");
                DrawLine();
                foreach (var student in branch.GetStudents())
                {



                    DrawLine();
                    Console.WriteLine($"StudentID : {student.Studentid} StudentName : {student.StudentName}");
                    DrawLine();
                    count = count + college.TotalStudents(c);
                    foreach (var fees in student.GetFees())
                    {

                        DrawLine();
                        Console.WriteLine($"Paid Date : {fees.PaidDt} Amount : {fees.Amount}");
                        DrawLine();
                        amount = amount + college.TotalFeesCollectedBrancwise(fees.Amount);

                    }

                }
                DrawLine();
                Console.WriteLine($"Total Fees Collected Branchwise : {amount}");
                total = total + college.TotalFeesCollected(amount);
            }
            DrawLine();
            Console.WriteLine($"Total Fees Collected : {total}");
            DrawLine();
            Console.WriteLine($"Total Students : {count}");

        }
        private static void DrawLine()
        {
            Console.WriteLine();
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
