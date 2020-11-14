﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.Entities
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHh { get; set; }
        [Required]
        [MaxLength(150)]
        public string TenHh { get; set; }
        public string MoTa { get; set; }
        public string Hinh { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }
    }
}
