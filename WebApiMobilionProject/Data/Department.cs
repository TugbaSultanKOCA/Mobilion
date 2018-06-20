using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMobilionProject.Data
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Required DepartmentName")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "DepartmentName Must be Minimum 2 Charaters")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Required DepartmentCode")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "DepartmentCode Must be Minimum 3 Charaters")]
        public string DepartmentCode { get; set; }

        public virtual ICollection<User> User { get; set; }

    }
}
