using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business
{
    public class GameClientManager : IGameClientService
    {
        List<ISaleService> _saleServices;
        public GameClientManager(List<ISaleService> saleService)
        {
            _saleServices = saleService;
        }


        public void BuyGame(IEntities game, IEntities user)
        {
            foreach (var sale in _saleServices)
            {
                sale.Discount(game);
            }
            Console.WriteLine("Tebrikler! " + user.Name + " Oyunu başarıyla aldınız : " + game.Name);
        }

        public void RefundGame(IEntities game, IEntities user)
        {
            Console.WriteLine("Tebrikler! " + user.Name + "" + " Oyunu başarıyla iade ettiniz : " + game.Name);
        }
    }
}
