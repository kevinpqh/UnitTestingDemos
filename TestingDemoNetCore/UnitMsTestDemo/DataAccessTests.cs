using DemoLibrary;
using DemoLibrary.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitMsTestDemo
{
    [TestClass]
    public class DataAccessTests
    {
        [TestMethod]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel newPerson = new PersonModel { FirstName = "Tim", LastName = "Corey" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.IsTrue(people.Count == 1);
            Assert.IsTrue(people.Contains(newPerson));

        }

        [DataTestMethod]
        [DataRow("Tim", "", "LastName")]
        [DataRow("", "Corey", "FirstName")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.ThrowsException<ArgumentException>(() => DataAccess.AddPersonToPeopleList(people, newPerson));

        }
    }
}
