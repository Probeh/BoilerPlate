using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Monster.Models
{
    public class Membership
    {
        [Key]
        public Guid Id { get; set; }
    }
}
