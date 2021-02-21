using System;
using System.Collections.Generic;
using System.ComponentModel;
using Upg1_Asp.Net.MVC.Data;

#nullable disable

namespace Upg1_Asp.Net.MVC.Entities
{
    public partial class SchoolClassStudent
    {
       
        [DisplayName("Student")]
        public string StudentId { get; set; }

        [DisplayName("School Class")]
        public Guid SchoolClassId { get; set; }

        public virtual SchoolClass SchoolClass { get; set; }
    }
}
