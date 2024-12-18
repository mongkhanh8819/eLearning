using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_Learning.Models;

namespace e_Learning.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            //var danhSachMayTinh = new MayTinh();
            MayTinh danhSachMayTinh = new MayTinh();
            List<MayTinh> danhSach5May = danhSachMayTinh.KhoiTao5May();
            return View(danhSach5May);
        }
        public ActionResult GetHaiMayGiaThapNhat()
        {
            MayTinh danhSachMayTinh = new MayTinh();
            List<MayTinh> danhSach2May = danhSachMayTinh.KhoiTao5May().OrderBy(m => m.giaBan).Take(2).ToList();
            return View(danhSach2May);
        }
        public ActionResult SapXepGiam()
        {
            MayTinh danhSachMayTinh = new MayTinh();
            List<MayTinh> sapXepGiam = danhSachMayTinh.KhoiTao5May().OrderBy(m => m.giaBan).ToList();
            return View(sapXepGiam);
        }
        public ActionResult HangAsus()
        {
            MayTinh danhSachMayTinh = new MayTinh();
            List<MayTinh> danhSachAsus = danhSachMayTinh.KhoiTao5May().Where(m => m.hangSanXuat == "Asus").ToList();
            return View(danhSachAsus);
        } 
    }
}