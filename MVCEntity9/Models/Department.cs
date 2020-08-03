using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntity9.Models
{
    public class Department
    {
        public int DepartmentId { set; get; }
        public string DepartmentName { set; get; }
        public string DepartmentLocation { set; get; }
        public DateTime DepartmentAddedDate { set; get; }
    }
}