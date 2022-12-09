using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekz2.Models
{
    [Table("Diagnosisss")]
    class Diagnosis
    {
        [Key]
        public int dnum { get; set; }
        public string sname { get; set; }
        public string city { get; set; }
        public int comm { get; set; }
    }
}
