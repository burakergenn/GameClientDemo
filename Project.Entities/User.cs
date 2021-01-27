using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class User : Person
    {
        //Burada bir oyuncunun/kullanıcının oluşturulması için gerekli bilgilerin iskeletini oluşturduk
        //Aynı zamanda bir oyuncu gerçekte bir kişi olacağı için kişiden inherit edildi
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        //burada bool kullandım true gelirse kadın false gelirse erkek gibi düşünelim
        public bool Gender { get; set; }
        public string Password { get; set; }

    }
}
