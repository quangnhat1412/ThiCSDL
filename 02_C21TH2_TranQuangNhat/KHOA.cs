using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("KHOA")]
    public class KHOA
    {
        [Key]
        [StringLength(2)]
        public string MaKH { get; set; }
        [StringLength(50)]
        public string TenKH { get; set; }
        public List<SINHVIEN> sinhviens { get; set; }
    }

