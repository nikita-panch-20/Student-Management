using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_StudentManagementSystem
{
    class College
    {
        public int CollegeID { get; set; }
        public string CollegeName { get; set; }
        private List<Branch> branches = new List<Branch>();

        public void AddBranch(Branch branch)
        {
            this.branches.Add(branch);
        }
        public List<Branch> GetBranches()
        {
            return this.branches;
        }

        public double TotalFeesCollectedBrancwise(double amount)
        {
            double amt = 0;
            amt = amt + amount;
            return amt;
        }

        public double TotalFeesCollected(double total)
        {
            double t = 0;
            t = t + total;
            return t;
        }
        public double TotalStudents(double count)
        {
            count++;
            return count;
        }

    }
}
