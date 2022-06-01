using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_connection.Models
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public String Nume { get; set; }
    }
}
