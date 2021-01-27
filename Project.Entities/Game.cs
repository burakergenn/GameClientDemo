using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Game : IEntities
    {
        //Burada bir oyunu oluşturmak için gerekli özelliklerin iskeletini oluşturuyoruz.
        public int Id { get; set; }
        public string Name { get; set; }
        public int GameId { get; set; }
        public string GamePublisher { get; set; }
        public string GameType { get; set; }
        public double UnitPrice { get; set; }


    }
}
