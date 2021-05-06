using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public int RegNumber { get; set; }
        public string Address { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Comment { get; set; }
        public ICollection<Office> Offices { get; set; }
        public ICollection<Hints> Hints { get; set; }
        public ICollection<Requests> Requests { get; set; }
    }
}
