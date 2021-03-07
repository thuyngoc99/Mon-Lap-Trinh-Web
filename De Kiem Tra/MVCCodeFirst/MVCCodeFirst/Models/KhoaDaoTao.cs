using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models
{
    public class KhoaDaoTao
    {
        [Key]
        public int MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string SoDienThoai { get; set; }
    }
}