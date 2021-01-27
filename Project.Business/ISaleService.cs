using System;
using System.Collections.Generic;
using System.Text;
using Project.Entities;

namespace Project.Business
{
    public interface ISaleService
    {
        void Discount(IEntities game);
    }
}
