using System;
using System.Collections.Generic;
using System.ComponentModel;
using Upg1_Asp.Net.MVC.Data;

#nullable disable

namespace Upg1_Asp.Net.MVC.Entities
{
    public partial class SchoolClass
    {
        public SchoolClass()
        {
            SchoolClassStudents = new HashSet<SchoolClassStudent>();
        }

        public Guid Id { get; set; }

        [DisplayName("School Class")]
        public string ClassName { get; set; }

        [DisplayName("Teacher")]
        public string TeacherId { get; set; }
        public DateTime Created { get; set; }

        
        public virtual AppUser Teacher { get; set; }
    

        public virtual ICollection<SchoolClassStudent> SchoolClassStudents { get; set; }
    }
}
