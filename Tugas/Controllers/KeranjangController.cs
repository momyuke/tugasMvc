using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tugas.Models;

namespace Tugas.Controllers
{
    public class KeranjangController : Controller
    {
        // GET: Keranjang
        [Route("daftarbarang")]
        public ActionResult DaftarBarang()
        {
            Barang daftarBarang = new Barang();

            return View(daftarBarang.DftrBarang());
        }
        [Route("tambah/{id}")]
        public ActionResult Tambah(string id)
        {
            if (TempData.Peek("keranjang") == null)
            {
                List<Keranjang> keranjang = new List<Keranjang>();
                TempData.Add("keranjang", keranjang);
            }

            Barang daftarBarang = new Barang();
            daftarBarang = daftarBarang.DftrBarang().Find(m => m.IdBarang.Equals(id));
            List<Keranjang> cek = (List<Keranjang>)TempData.Peek("keranjang");
            if (cek.Contains(cek.Find(m => m.IdBarang.Equals(id))))
            {
                int index = cek.FindIndex(m => m.IdBarang.Equals(id));
                cek[index].Quantity += 1;
                return Redirect("~/keranjang");
            }
            return View(daftarBarang);
        }

       
        [Route("store")]
        public ActionResult Store (Keranjang krnjg)
        {
            List<Keranjang> keranjangku = (List<Keranjang>)TempData.Peek("keranjang");
            keranjangku.Add(krnjg);
            return Redirect("~/keranjang");
        }
        [Route("keranjang")]
        public ActionResult KeranjangBelanja()
        {
            List<Keranjang> keranjang = (List<Keranjang>)TempData.Peek("keranjang");
            return View(keranjang);
        }

        [Route("edit/{id}")]
        public ActionResult Edit(string id)
        {
            List<Keranjang> cek = (List<Keranjang>)TempData.Peek("keranjang");
            Keranjang Popok = cek.Find(m => m.IdBarang == id);
           
            return View(Popok);

        }
        [Route("update")]
        public ActionResult Update(Keranjang p)
        {
            List<Keranjang> krjg = (List<Keranjang>)TempData.Peek("keranjang");
            int index = krjg.FindIndex(m => m.IdBarang == p.IdBarang);
            krjg[index].Quantity = p.Quantity;
            return Redirect("~/keranjang");
        }
        
        [Route("hapus/{id}")]
        public ActionResult Hapus(string id)
        {
            List<Keranjang> krjg = (List<Keranjang>)TempData.Peek("keranjang");
            Keranjang data = krjg.Find(m => m.IdBarang == id);
            krjg.Remove(data);
            return Redirect("~/keranjang");
        }
    }
}