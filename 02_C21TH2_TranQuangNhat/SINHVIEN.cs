using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SINHVIEN
{
    [Key]
    [StringLength(3)]
    public string MaSV { get; set; }
    [StringLength(50)]
    public string HoTen { get; set; }
    public int SoMon { get; set; }
    public string MaKH { get; set; }
    public KHOA khoa { get; set; }
   
}

