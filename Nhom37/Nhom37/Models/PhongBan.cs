﻿using System;
using System.Collections.Generic;

namespace Nhom37.Models
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        public int MaPb { get; set; }
        public string TenPb { get; set; }

        public ICollection<NhanVien> NhanVien { get; set; }
    }
}
