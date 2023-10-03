using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("MONHOC")]
public class MONHOC
{
    [Key]
    [StringLength(2)]
    public string MaMH { get; set; }

    [StringLength(45)]
    public string TenMH { get; set; }

    public int SoTiet { get; set; }

    public List<KETQUA> KETQUAs { get; set; }
}

