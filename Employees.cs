using Marten.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD3.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string EIT { get; set; }
        public string EFinance { get; set; }
        public string EMaintainance { get; set; }
        public string EAccounting { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("DID")]
        public Departments DeptID  { get; set; }       

    }
}
