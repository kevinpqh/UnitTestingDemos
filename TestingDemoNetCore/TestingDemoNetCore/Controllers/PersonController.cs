using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTestingDemo.Interface;
using DataTestingDemo.Moldels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingDemoNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IPersonRepo _personRepo;

        public PersonController(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }


        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            try
            {
                return _personRepo.LoadData();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        [HttpPost]
        public ActionResult<Person> Post([FromBody] Person person)
        {
            try
            {
                return _personRepo.SaveData(person);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        [HttpPut("{id}")]
        public ActionResult<Person> Put(int id, [FromBody] Person person)
        {
            try
            {
                person.Idperson = id;
                return _personRepo.UpdateData(person);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}