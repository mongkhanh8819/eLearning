using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_Learning.Helper;
using e_Learning.Models;

namespace e_Learning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Cách 1: Truyền bằng ViewBag
            //int a = 10;
            MathHelp help = new MathHelp();
            ViewBag.a = help.TinhGiaiThua(10);

            //Cách 2: Truyền qua tham số của hàm View
            //return View();
            //return View(10); ví dụ truyền số 10

            List<clsSinhVien> dsSinhVien = new List<clsSinhVien>();

            clsSinhVien sinhVien1 = new clsSinhVien();
            var sinhVien2 = new clsSinhVien();
            sinhVien2.maSV = 1001;
            sinhVien2.hoTen = "Dương Mộng Khánh";
            sinhVien2.queQuan = "An Giang";

            //ví dụ truyền class bằng ViewBag
            sinhVien1.maSV = 1002;
            sinhVien1.hoTen = "Mộng Khánh";
            sinhVien1.queQuan = "Cần Thơ";
            //ViewBag.sinhVien1 = sinhVien1;

            var sinhVien3 = new clsSinhVien();
            sinhVien3.maSV = 1003;
            sinhVien3.hoTen = "Thu Trang";
            sinhVien3.queQuan = "Cần Thơ";

            dsSinhVien.Add(sinhVien1);
            dsSinhVien.Add(sinhVien2);
            dsSinhVien.Add(sinhVien3);


            
            return View(dsSinhVien);
        }
    }
}