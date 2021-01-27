using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess
{
    public class SmsLoggerManager : ILoggerService
    {
        //Burada da oyuncuların yaptıkları her işlem için sms gönderdiğimizi simüle edelim
        public void Add(IEntities entities)
        {
            Console.WriteLine(entities.Name + " : SMS Bildirimi yapıldı");
        }

        public void Delete(IEntities entities)
        {
            Console.WriteLine(entities.Name + " :  SMS Bildirimi yapıldı");
        }

        public void Update(IEntities entities)
        {
            Console.WriteLine(entities.Name + " :  SMS Bildirimi yapıldı");
        }
    }
}
