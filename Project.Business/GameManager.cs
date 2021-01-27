using System;
using System.Collections.Generic;
using System.Text;
using Project.Entities;
using Project.DataAccess;

namespace Project.Business
{
    public class GameManager : IOperationService
    {
        List<ILoggerService> _loggerGameServices;
        public GameManager(List<ILoggerService> loggerServices)
        {
            _loggerGameServices = loggerServices;
        }

        public void Add(IEntities game)
        {
            //burada ekleme yaparken oyun isminin boş bırakılmaması için null dan farklı bir değer olmasını istiyoruz.
            foreach (var logger in _loggerGameServices)
            {
                if (game.Name != null)
                {
                    logger.Add(game);
                    Console.WriteLine(game.Name + " : Oyun Eklendi");
                }
                else
                {
                    Console.WriteLine("Lütfen Bir Oyun İsmi Giriniz!");
                }

            }


        }

        public void Delete(IEntities game)
        {
            foreach (var logger in _loggerGameServices)
            {
                logger.Delete(game);
            }
            Console.WriteLine(game.Name + " : Oyun Silindi");
        }

        public void Update(IEntities game)
        {
            foreach (var logger in _loggerGameServices)
            {
                logger.Update(game);
            }
            Console.WriteLine(game.Name + " : Oyun Güncellendi");
        }
    }
}
