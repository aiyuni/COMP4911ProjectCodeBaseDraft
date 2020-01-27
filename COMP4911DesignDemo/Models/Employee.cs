﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace COMP4911DesignDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [ForeignKey("JobId")]
        public int JobId { get; set; }

        public string EmployeeName { get; set; }

        public int? TimesheetApproverId { get; set; }
        public int? SupervisorId { get; set; }

        public Employee TimesheetApprover { get; set; }
        public Employee Supervisor { get; set; }

        public Timesheet Timesheet { get; set; }

        public IList<EmployeeProjectAssignment> EmployeeProjectAssignments { get; set; }
        public IList<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }
    }
}