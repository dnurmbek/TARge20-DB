using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Child
    {
     [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string PersonalCode { get; set; }
        public string? Comment { get; set; }
        public Employee Employee { get; set; }
    }
}
