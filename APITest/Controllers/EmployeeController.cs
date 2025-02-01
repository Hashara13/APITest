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

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeByID(Guid id)
        {
           var employeeID=dbContext.Employees.Find(id);
            if(employeeID is null)
            {
                return NotFound("Cant Found Employee");
            }
           return Ok(employeeID);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateEmployee(Guid id,UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound("Cant Found Employee");
            }

            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Phone = updateEmployeeDto.Phone;
            employee.Salary = updateEmployeeDto.Salary;

            dbContext.SaveChanges();
            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeleteEmployee(Guid id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound("Cant Found Employee");
            }

            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return Ok(employee);

        }
    }

    
}
