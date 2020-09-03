using DataTestingDemo.Interface;
using DataTestingDemo.Moldels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataTestingDemo.Implementacion
{
    public class PersonRepo : IPersonRepo
    {
        public List<Person> LoadData()
        {
            try
            {
                using (var ctx = new TestingDBContext())
                {
                    List<Person> list = ctx.Person.ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person SaveData(Person person)
        {
            try
            {
                using (var ctx = new TestingDBContext())
                {
                    ctx.Add(person);
                    ctx.SaveChanges();
                    return person;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person UpdateData(Person person)
        {
            try
            {
                using (var ctx = new TestingDBContext())
                {
                    Person perUpt = ctx.Person.Where(whr => whr.Idperson == person.Idperson).FirstOrDefault();
                    if (perUpt == null) throw new Exception("NO HAY ENTIDAD");

                    perUpt.Firstname = person.Firstname;
                    perUpt.Lastname = person.Lastname;

                    ctx.SaveChanges();
                    return person;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
