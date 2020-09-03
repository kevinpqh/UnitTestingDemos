using DataTestingDemo.Moldels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTestingDemo.Interface
{
    public interface IPersonRepo
    {
        List<Person> LoadData();
        Person SaveData(Person person);
        Person UpdateData(Person person);
    }
}
