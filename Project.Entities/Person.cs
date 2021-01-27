using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities
{
    public class Person : IEntities
    {
        //Burada bir kişi oluşturmak için gerekli olan bilgilerin iskeleti oluşturuldu.
        public int Id { get; set; }
        public string Name { get; set; }
        public string NationalityId { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }

    }
}
