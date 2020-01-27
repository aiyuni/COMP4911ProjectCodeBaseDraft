using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911DesignDemo.Models
{
    public class WorkPackage
    {
        [Key]
        public int WorkPackageId { get; set; }
        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }
        
        public string WorkPackageName { get; set; }
        public string WorkPackageDescription { get; set; }
        public double? WorkPackageCost { get; set; }

        [ForeignKey("ParentWorkPackage")]
        public int? ParentWorkPackageId { get; set; }
        public virtual WorkPackage ParentWorkPackage { get; set; }
        public virtual IList<WorkPackage> ChildrenWorkPackages { get; set; }

        public Project Project { get; set; }

        public IList<TimesheetRow> TimesheetRows { get; set; }
        public IList<EmployeeWorkPackageAssignment> EmployeeWorkPackageAssignments { get; set; }
    }
}
