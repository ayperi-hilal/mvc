using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace site2.Models.Sınıflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string baslik { get; set; }
        public string Aciklama { get; set; }
        public string adres { get; set; }
        public string Mail { get; set; }
        public string telNo { get; set; }
        public string Konum { get; set; }

    }
}