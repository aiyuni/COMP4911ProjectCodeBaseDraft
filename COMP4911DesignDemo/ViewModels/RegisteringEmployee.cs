using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911DesignDemo.ViewModels
{
    public class RegisteringEmployee
    {
        public string EmpUsername { get; set; }
        public string EmpPassword { get; set; }
        public string JobTitle { get; set; }
        public string LabourGrade { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }

        public RegisteringEmployee(string empUsername, string empPassword, string jobTitle, string labourGrade, string empFirstName, string empLastName)
        {
            this.EmpUsername = empUsername;
            this.EmpPassword = empPassword;
            this.JobTitle = jobTitle;
            this.LabourGrade = labourGrade;
            this.EmpFirstName = empFirstName;
            this.EmpLastName = empLastName;
        }
    }
}
