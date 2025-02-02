using ASHCodingTest.Models;

namespace ASHCodingTest.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Task<List<Worker>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
        //reduces redundancy on people
        public bool PersonExists(string? firstName, string? lastName, string? address) 
        { 

            return false;
            //throw new NotImplementedException();
        }
        //reduces redundancy on paytypes
        public bool PayTypeExists(string? name, decimal? amount)
        {
            return false;
            //throw new NotImplementedException();
        }

        public Task<Worker> AddEmployee(string workertype, decimal? maxExpenseType, Person per, PayType pay)
        {
            var worker = new Worker()
            {
                WorkerType = workertype,
                MaxExpenseAccout = maxExpenseType,
                PersonId = per.Id,
                PayTypeId = pay.Id
            };

            //insert into db

            return worker;//fix
            //throw new NotImplementedException();
        }
    }
}
