﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911DesignDemo.Models
{
    public class TimesheetRow
    {
        [Key]
        public int TimesheetRowId { get; set; }

        public int TimesheetId { get; set; }
        public int WorkPackageId { get; set; }

        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public int Sunday { get; set; }

        public Timesheet Timesheet { get; set; }
        public WorkPackage WorkPackage { get; set; }

    }
}
