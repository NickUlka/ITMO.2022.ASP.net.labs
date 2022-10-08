using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO._2022.ASP.net.MVC.lab.Models
{
    //поле, описывающие коллекцию – список персон
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();

    //        два свойства только для чтения – первое должно
    //возвращать количество персон, второе – саму коллекцию:
        public int NumberOfPerson
 {
 get
 {
 return persons.Count();
 }
}
public IEnumerable<Person> GetAllResponses
{
    get
    {
        return persons;
    }
}
        // Для возможности добавления персон в коллекцию 
        public void AddResponse(Person pers)
        {
            persons.Add(pers);
        }

    }
}