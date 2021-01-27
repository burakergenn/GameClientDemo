using System;
using Project.Entities;
using Project.DataAccess;
using Project.Business;
using System.Collections.Generic;

namespace Project.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService databaseLoggerManager = new DatabaseLoggerManager();
            ILoggerService smsLoggerManager = new SmsLoggerManager();


            IPersonCheckService personCheckManager = new PersonCheckManager();
            IOperationService userManager = new UserManager(new List<ILoggerService> { databaseLoggerManager, smsLoggerManager }, new List<IPersonCheckService> { personCheckManager });


            Person burak = new User
            { Id = 100, UserId = 123123, NationalityId = "11111111111", Name = "Burak", LastName = "Ergen", UserName = "asdfasdf", DateOfBirth = 1995 / 01 / 06, Gender = false, Email = "burak@", Password = "asdfasdf" };
            Person anil = new User
            { Id = 101, UserId = 321321, NationalityId = "22222222222", Name = "Anıl", LastName = "Güzel", UserName = "qwerqwer", DateOfBirth = 1995 / 06 / 19, Gender = false, Email = "anil@", Password = "qwerqwer" };
            Person ayca = new User
            { Id = 102, UserId = 456456, NationalityId = "33333333333", Name = "Ayça", LastName = "Es", UserName = "zxcvzxcv", DateOfBirth = 1996 / 01 / 06, Gender = true, Email = "ayca@", Password = "zxcvzxcv" };
            Person elif = new User
            //Burada UserManager i test etmek amaçlı bir tane kullanıcıya isim vermiyorum bakalım sisteme ekliyor mu yoksa hata mesajı veriyormu diye.
            { Id = 103, UserId = 789789, NationalityId = "44444444444", LastName = "Türk", UserName = "jklsjkls", DateOfBirth = 2005 / 10 / 20, Gender = true, Email = "elif@", Password = "jklsjkls" };
            userManager.Add(burak);
            userManager.Update(anil);
            userManager.Delete(ayca);
            userManager.Add(elif);

            IOperationService gameManager = new GameManager(new List<ILoggerService> { smsLoggerManager, databaseLoggerManager });

            IEntities counterStrike = new Game { Id = 1, GameId = 22, Name = "CS:GO", UnitPrice = 77, GameType = "Competitive-FPS", GamePublisher = "Valve" };
            IEntities dota2 = new Game { Id = 2, GameId = 23, Name = "Dota2", UnitPrice = 85, GameType = "Competitive-MOBA", GamePublisher = "Valve" };
            //Burada UserManager i test etmek amaçlı  oyuna isim vermiyorum bakalım isteme ekliyor mu yoksa hata mesajı veriyormu diye.
            IEntities valorant = new Game { Id = 3, GameId = 24, UnitPrice = 20, GameType = "Competitive-FPS", GamePublisher = "Riot Games" };
            IEntities leagueOfLegends = new Game { Id = 4, GameId = 24, Name = "LeagueOfLegends", UnitPrice = 50, GameType = "Competitive-MOBA", GamePublisher = "Riot Games" };

            gameManager.Add(counterStrike);
            gameManager.Update(dota2);
            gameManager.Delete(leagueOfLegends);
            gameManager.Add(valorant);


            ISaleService discount = new SalesManager();
            IGameClientService gameClient = new GameClientManager(new List<ISaleService> { discount });

            gameClient.BuyGame(counterStrike, burak);
            gameClient.BuyGame(dota2, anil);
            gameClient.RefundGame(leagueOfLegends, ayca);
        }
    }
}
