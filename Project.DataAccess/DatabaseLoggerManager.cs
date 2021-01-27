using System;
using System.Collections.Generic;
using System.Text;
using Project.Entities;

namespace Project.DataAccess
{
    public class DatabaseLoggerManager : ILoggerService
    {
        //Burada oluşturulan kullanıcıların ve oyunların yaptığı işlemleri simüle edelim
        public void Add(IEntities entities)
        {
            Console.WriteLine(entities.Id + " - " + entities.Name + " " + "Database e eklendi");
        }

        public void Delete(IEntities entities)
        {
            Console.WriteLine(entities.Id + " - " + entities.Name + " " + "Databaseden silindi");
        }

        public void Update(IEntities entities)
        {
            Console.WriteLine(entities.Id + " - " + entities.Name + " " + "Databasede Güncellendi");
        }
    }
}
