using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tugas.Models
{
    public class Keranjang
    {
        public double Quantity { get; set; }
        public string IdBarang { get; set; }

        
        public Barang daftarBarangku()
        {

            Barang DftrBarang = new Barang();
            return DftrBarang.DftrBarang().Find(m => m.IdBarang.Equals(this.IdBarang));
        }
            
     }
}