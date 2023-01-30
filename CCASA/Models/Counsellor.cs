using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCASA.Models
{
    public class Counsellor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Qualification { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string BloodGroup { get; set; }
        public string Messege { get; set; }
    }
}
