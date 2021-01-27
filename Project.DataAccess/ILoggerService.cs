using System;
using System.Collections.Generic;
using System.Text;
using Project.Entities;

namespace Project.DataAccess
{
    public interface ILoggerService
    {
        //Burada log servisimizin yapacağı işlemleri belirledik.
        void Add(IEntities entities);
        void Update(IEntities entities);
        void Delete(IEntities entities);
    }
}
