using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessType
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string? Comment { get; set; }

        public ICollection<AccessPermit> AccessPermits { get; set; }
    }
}
