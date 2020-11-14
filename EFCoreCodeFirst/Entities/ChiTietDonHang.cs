using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Entities
{
    [Table("ChiTietDonHang")]
    public class ChiTietDonHang
    {
        [Key]
        public Guid MaCtDh { get; set; }
        public Guid MaDh { get; set; }
        [ForeignKey("MaDh")]
        public DonHang DonHang { get; set; }

        public Guid MaHh { get; set; }
        [ForeignKey("MaHh")]
        public HangHoa HangHoa { get; set; }

        public int SoLuong { get; set; }
    }
}
