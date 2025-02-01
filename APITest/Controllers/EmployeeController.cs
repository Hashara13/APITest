using System.ComponentModel.DataAnnotations;
using APITest.Data;
using APITest.Models;
using APITest.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetEmployee()
        {
            var allEmployeess=dbContext.Employees.ToList();
            return Ok(allEmployeess);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployreeDto)
        {

            var employeeEntity = new Employee()
            {
                Name = addEmployreeDto.Name,
                Email = addEmployreeDto.Email,
                Phone = addEmployreeDto.Phone,
                Salary = addEmployreeDto.Salary,

            };


            dbContext.Employees.Add(employeeEntity);
            dbContext.SaveChanges();

            return Ok(employeeEntity);
        }

    }
}
