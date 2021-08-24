using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Admin
    {
        [Key]
        //ilk değeri key yapar
        public int AdminID { get; set; }
        [Column(TypeName ="Varchar(20)") ]
        //max giriş karakter syaısı
        public string Kullanici { get; set; }

        [Column(TypeName = "Varchar(20)")]
        //max giriş karakter sayısı
        public string Sifre { get; set; }

    }
}
