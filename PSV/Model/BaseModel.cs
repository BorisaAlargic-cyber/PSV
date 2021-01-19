using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public bool Deleted { get; set; }
    }
}
