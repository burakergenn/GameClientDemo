using Project.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business
{
    public class PersonCheckManager : IPersonCheckService
    {
        public void CheckPerson(Person person)
        {
            //ben oyun consoleumu kullanacak kişilerin 15 yaşından büyük olmalarını istedim ona göre kurallar girdim.
            if (person.NationalityId.Length > 10 && person.Name.Length >= 2 && person.LastName.Length >= 2 && person.DateOfBirth <= 2006)
            {
                Console.WriteLine("Doğrulamadan Geçti");
            }
            else
            {
                Console.WriteLine("Doğrulamadan geçemedi bilgilerinizi kontrol ediniz");
            }
        }
    }
}
