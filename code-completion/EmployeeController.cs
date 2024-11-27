using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee
            {
                Name = "John Doe",
                Position = "Software Engineer",
                Contact = new Contact
                {
                    Email = "john.doe@example.com",
                    Phone = "123-456-7890"
                }
            },
            new Employee
            {
                Name = "Jane Smith",
                Position = "Project Manager",
                Contact = new Contact
                {
                    Email = "jane.smith@example.com",
                    Phone = "098-765-4321"
                }
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return Ok(Employees);
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Contact Contact { get; set; }
    }

    public class Contact
    {
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}