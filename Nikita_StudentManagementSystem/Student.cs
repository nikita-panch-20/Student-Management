using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_StudentManagementSystem
{
    class Student
    {
        public int Studentid { get; set; }
        public string StudentName { get; set; }

        public Branch Branch { get; set; }

         private List<Fees> fees = new List<Fees>();
      //public Fees fees;

        public void AddFees(Fees fees)
        {
            this.fees.Add(fees);
        }

        public List<Fees> GetFees()
        {
            return this.fees;
        }
       



    }
}
