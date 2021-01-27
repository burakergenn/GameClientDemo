using Project.DataAccess;
using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business
{
    public class UserManager : IOperationService
    {
        public UserManager(IEntities entities)
        {

        }
        //Burada bir liste oluşturup kullanıcı ekleme silme güncelleme gibi işlemleri yaparken oyuncuları bu listede tutuyoruz.
        List<ILoggerService> _loggerUserServices;
        public UserManager(List<ILoggerService> loggerServices, List<IPersonCheckService> personChecks)
        {
            _loggerUserServices = loggerServices;
        }

        public void Add(IEntities user)
        {
            foreach (var logger in _loggerUserServices)
            {
                //burada ekleme yaparken oyuncu isminin boş bırakılmaması için null dan farklı bir değer olmasını istiyoruz.
                if (user.Name != null)
                {
                    logger.Add(user);
                    Console.WriteLine(user.Name + " : Oyuncu Eklendi");
                }
                else
                {
                    Console.WriteLine("Lütfen Bir Oyuncu İsmi Giriniz!");
                }

            }


        }

        public void Delete(IEntities user)
        {
            foreach (var logger in _loggerUserServices)
            {
                logger.Delete(user);
            }
            Console.WriteLine(user.Name + " : Oyuncu Silindi");
        }

        public void Update(IEntities user)
        {
            foreach (var logger in _loggerUserServices)
            {
                logger.Update(user);
            }
            Console.WriteLine(user.Name + " : Oyuncu Güncellendi");
        }
    }
}
