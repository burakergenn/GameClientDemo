using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public interface IEntities
    {
        //Burada oyunlarda ve kişilerde ortak bulunan özellikleri bir interface aracılığıyla tanımladık.
        int Id { get; set; }
        string Name { get; set; }
    }
}
