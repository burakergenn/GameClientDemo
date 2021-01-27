using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business
{
    public class SalesManager : ISaleService
    {
        public void Discount(IEntities game)
        {
            Console.WriteLine(game.Name + "Oyuna indirim uygulandı");
        }
    }
}
