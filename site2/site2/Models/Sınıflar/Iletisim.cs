using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace site2.Models.Sınıflar
{
    public class Iletisim
    {
        [Key]
        public int ID { get; set; }
        public string adSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }
    }
}