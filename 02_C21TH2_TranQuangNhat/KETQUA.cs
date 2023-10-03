using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("KETQUA")]
public class KETQUA
{
    [Key]
    [Column(Order = 0)]
    [StringLength(3)]
    public string MaSV { get; set; }

    [Key]
    [Column(Order = 1)]
    [StringLength(2)]
    public string MaMH { get; set; }

    public float Diem { get; set; }
    public MONHOC MONHOC { get; set; }
    public SINHVIEN SINHVIEN { get; set; }
}
