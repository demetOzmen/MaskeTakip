using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Demet";
person1.LastName = "Özmen";
person1.DateOfBirthYear = 1992;
person1.NationalIdentity = 12713201322;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);