using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace site2.Models.Sınıflar
{
    public class hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string resimUrl { get; set; }
        public string aciklama { get; set; }
    }
}