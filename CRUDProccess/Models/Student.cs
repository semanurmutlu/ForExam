using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDProccess.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Surname { get; set; }

        [StringLength(11)]
        public string TC { get; set; }

        [StringLength(50)]
        public string Address  { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Education { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

    }
}
