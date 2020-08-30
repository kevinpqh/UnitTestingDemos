using DemoLibrary;
using DemoLibrary.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemoLibrary.Tests
{
    public class DataAccessTests
    {
        [Test]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains(newPerson, people);
        }

        [TestCase("Tim", "", "LastName")]
        [TestCase("", "Corey", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(() => DataAccess.AddPersonToPeopleList(people, newPerson));

        }
    }
}
