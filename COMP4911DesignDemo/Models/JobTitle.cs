using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP4911DesignDemo.Models
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }

        public string JobTitleName { get; set; }
    }
}
