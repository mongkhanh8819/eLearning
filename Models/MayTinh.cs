using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Learning.Models
{
    public class MayTinh
    {
        public string maMay {  get; set; }
        public string dongMay { get; set; }
        public double giaBan { get; set; }
        public DateTime ngaySanXuat { get; set; }
        public string hangSanXuat { get; set;}

        public List<MayTinh> KhoiTao5May()
        {
            List<MayTinh> danhSachMayTinh = new List<MayTinh>();
            danhSachMayTinh.Add(new MayTinh()
            {
                maMay = "0000000001",
                dongMay = "Asus x6353",
                giaBan = 15000000,
                ngaySanXuat = new DateTime(2020, 1, 29),
                hangSanXuat = "Asus"
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                maMay = "0000000002",
                dongMay = "Asus x3434",
                giaBan = 25000000,
                ngaySanXuat = new DateTime(2021, 2, 28),
                hangSanXuat = "Asus"
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                maMay = "0000000003",
                dongMay = "Dell x1453",
                giaBan = 19000000,
                ngaySanXuat = new DateTime(2022, 3, 29),
                hangSanXuat = "Dell"
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                maMay = "0000000004",
                dongMay = "Lenovo Ideapad",
                giaBan = 15000000,
                ngaySanXuat = new DateTime(2023, 1, 29),
                hangSanXuat = "Lenovo"
            });
            danhSachMayTinh.Add(new MayTinh()
            {
                maMay = "0000000005",
                dongMay = "Lenovo Thinkpad",
                giaBan = 15000000,
                ngaySanXuat = new DateTime(2019, 1, 29),
                hangSanXuat = "Lenovo"
            });
            return danhSachMayTinh;
        }

    }
}