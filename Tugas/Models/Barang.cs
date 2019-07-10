using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tugas.Models
{
    public class Barang
    {
        public string IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public double HargaBarang { get; set; }

        private List<Barang> daftarBarang = new List<Barang>();
        public List<Barang> DftrBarang()
        {
            this.daftarBarang.Add(new Barang { IdBarang = "A01", NamaBarang = "Xiaomi Mi 9", HargaBarang = 5000000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A02", NamaBarang = "Redmi K20 Pro", HargaBarang = 5000000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A03", NamaBarang = "Oneplus 7 Pro", HargaBarang = 10300000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A04", NamaBarang = "Samsung Galaxy S10+", HargaBarang = 13000000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A05", NamaBarang = "Xiaomi Mi Mix 3", HargaBarang = 6000000 });

            this.daftarBarang.Add(new Barang { IdBarang = "A06", NamaBarang = "Huawei P20 Pro", HargaBarang = 8000000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A07", NamaBarang = "Huawei P30 Pro", HargaBarang = 13000000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A08", NamaBarang = "Oppo Find X", HargaBarang = 12000000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A09", NamaBarang = "Vivo Nex", HargaBarang = 12000000 });
            this.daftarBarang.Add(new Barang { IdBarang = "A10", NamaBarang = "Asus Zenfone 6 2019", HargaBarang = 13000000 });
                return daftarBarang;
        }
    }
}