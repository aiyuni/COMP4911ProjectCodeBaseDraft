using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace COMP4911DesignDemo.Models
{
    public class Credential
    {
        [Key]
        public string CredentialId { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        public string Password { get; set; }

        public Employee Employee { get; set; }
    }
}
