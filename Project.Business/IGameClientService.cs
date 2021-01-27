using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Project.Business
{
    public interface IGameClientService
    {
        void BuyGame(IEntities game, IEntities user);
        void RefundGame(IEntities game, IEntities user);
    }
}
