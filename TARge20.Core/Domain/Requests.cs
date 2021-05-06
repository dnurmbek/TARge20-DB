using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
   public class Requests
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string? Comment { get; set; }
        public string? PersonName { get; set; }
        public RequestStatus Status { get; set; }
        public Company Company { get; set; }
    }
}
