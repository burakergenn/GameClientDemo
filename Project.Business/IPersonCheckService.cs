using System;
using System.Collections.Generic;
using System.Text;
using Project.Entities;

namespace Project.Business
{
    public interface IPersonCheckService
    {
        void CheckPerson(Person person);
    }
}
