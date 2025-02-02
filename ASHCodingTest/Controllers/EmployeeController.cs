using Microsoft.AspNetCore.Mvc;
using ASHCodingTest.Services;
using ASHCodingTest.Models;

namespace ASHCodingTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDataService _dataService;

        public EmployeeController(IEmployeeService employeeService, IDataService dataService)
        {
            _employeeService = employeeService;
            _dataService = dataService;
        }

        [HttpGet("/employee")]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();

            return Ok(employees);
        }

        [HttpPost("/employee")]
        public async Task<IActionResult> CreateNewEmployee(string? firstName, string? lastName, string? address1, string? paytype, decimal? payvalue, decimal? maxExpenseAccount)
        {
            try
            {

                var worker = BuildWorker(firstName ,lastName ,address1 ,paytype ,payvalue ,maxExpenseAccount);
            }
            catch (Exception ex) { 
            //log error
            }

            return BadRequest();
        }

        private Worker BuildWorker(string? firstName, string? lastName, string? address1, string? paytype, decimal? payvalue, decimal? maxExpenseAccount)
        {
            var worker = new Worker();

            //check for existing person
            var existingEmployee = _employeeService.PersonExists(firstName, lastName, address1);
            if (existingEmployee == null)
            {
                if (maxExpenseAccount != null)//only managers have this
                {
                    worker.WorkerType = "Manager"; //offload to constants later
                    worker.MaxExpenseAccout = maxExpenseAccount;
                }
                else if (worker.PayTypeId == 2)//salaried
                {
                    worker.WorkerType = "Supervisor";
                }
                else
                {
                    worker.WorkerType = "Employee";
                }
            }
            else
            {
                //look up paytype/person data and apply
            }
    }
}
