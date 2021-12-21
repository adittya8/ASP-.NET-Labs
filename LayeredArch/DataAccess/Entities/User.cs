using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pass { get; set; }
        public short UserType { get; set; }
        public string Picture { get; set; }
        public bool IsVerified { get; set; }
        public DateTime Dob { get; set; }
    }
}
