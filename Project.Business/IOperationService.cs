using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business
{
    public interface IOperationService
    {
        void Add(IEntities entities);
        void Delete(IEntities entities);
        void Update(IEntities entities);
    }
}
