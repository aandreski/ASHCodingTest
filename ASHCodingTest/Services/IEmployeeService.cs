using ASHCodingTest.Models;

namespace ASHCodingTest.Services
{
    public interface IEmployeeService
    {
        Task<List<Worker>> GetAllEmployees();
        Task<Worker> AddEmployee(string workertype, decimal? maxExpenseType, Person per, PayType pay);
        public Person PersonExists(string? firstName, string? lastName, string? address);
        public bool PayTypeExists(string? name, decimal? amount);
    }
}
