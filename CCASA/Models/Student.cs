using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CCASA.Models
{
    public class Student:AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Institute { get; set; }
        public int MatricMarks { get; set; }
        public int IntermediateMarks { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string BloodGroup { get; set; }
        public string Messege { get; set; }
    }
}
