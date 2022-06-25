using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace site2.Models.Sınıflar
{
    public class yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullanciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual blog Blog { get; set; }
       
    }
}