using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_StudentManagementSystem
{
    class Branch
    {
        public int Branchid { get; set; }
        public string BranchName { get; set; }
        public College College { get; set; }

        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public List<Student> GetStudents()
        {
            return this.students;
        }
       

    }
}
