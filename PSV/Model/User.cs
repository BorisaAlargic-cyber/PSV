using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Speciality { get; set; }
        public bool FirstTime { get; set; }
        public User ChoosenDoctor { get; set; }
        public bool Blocked { get; set; }
    }
}
