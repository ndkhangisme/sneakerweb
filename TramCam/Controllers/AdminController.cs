using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TramCam.Models;

namespace TramCam.Controllers
{
    public class AdminController : Controller
    {

        SneakerDBContext dbSneaker = new SneakerDBContext();
        public ActionResult Index()
        {
            var listSneaker = dbSneaker.Sneakers.ToList();

            return View(listSneaker);
        }

        public ActionResult Detail(int id)
        {
            var D_sneaker = dbSneaker.Sneakers.Where(m => m.MaGiay == id).First();

            return View(D_sneaker);
        }       

        public ActionResult Edit(int id)
        {
            var D_sneaker = dbSneaker.Sneakers.Select(p => p).Where(p => p.MaGiay == id).FirstOrDefault();
            return View(D_sneaker);
        }

        [HttpPost]
        public ActionResult Edit(Sneaker editedSneaker)
        {
            try
            {
                var D_sneaker = dbSneaker.Sneakers.Select(p => p).Where(p => p.MaGiay == editedSneaker.MaGiay).FirstOrDefault();
                D_sneaker.TenGiay = editedSneaker.TenGiay;
                D_sneaker.MaLoai = editedSneaker.MaLoai;
                D_sneaker.MoTa = editedSneaker.MoTa;
                D_sneaker.Gia = editedSneaker.Gia;
                D_sneaker.Hinh = editedSneaker.Hinh;
                dbSneaker.SaveChanges();
                return RedirectToAction("Index");   
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create() 
        { 
            return View(); 
        }
        
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "MaGiay")] Sneaker newSneaker)
        {

            try
            {

                dbSneaker.Sneakers.Add(newSneaker); 
                dbSneaker.SaveChanges(); 
                return RedirectToAction("Index");

            }
            catch { return View(); }

        }

        public ActionResult Delete(int id)
        {
            var phone = dbSneaker.Sneakers.Select(p => p).Where(p => p.MaGiay == id).FirstOrDefault();
            return View(phone);
        }

        
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            try
            {

                var sneaker = dbSneaker.Sneakers.Select(p => p).Where(p => p.MaGiay == id).FirstOrDefault();

                if (sneaker != null)
                {

                    dbSneaker.Sneakers.Remove(sneaker);

                    dbSneaker.SaveChanges();

                }

                return RedirectToAction("Index");

            }
            catch 
            {               
              return View(); 
            }

        }
    }
}