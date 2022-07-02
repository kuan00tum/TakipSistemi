
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{

    class program
    {
        static void Main(string[] args)
        {
  
            Person person1 = new Person();
            person1.FirstName = "ARİF";
            person1.LastName = "ERDOĞAN";
            person1.DateofBirthYear = 1994;
            person1.NationalIdentity = 41674964854;



            Person person2 = new Person();
            person2.FirstName = "ENGİN";
            person2.LastName = "DEMİROĞ";
            person2.DateofBirthYear = 1985;
            person2.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());

            pttManager.GiveMask(person1);
            
            Console.ReadLine();


            

        }

       
    }
    public class Vatandaş
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int Doğumyılı { get; set; }
        public long Tc { get; set; }

    }

}
