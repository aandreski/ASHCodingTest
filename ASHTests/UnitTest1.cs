namespace ASHTests
{
    [TestFixture]
    public class EmployeeApiTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetEmployees_ReturnsListOfEmployees()
        {
            //setup db connection
            //run query to get all workers(unfilled)
            //assert a non-empty list was returned
        }

        [Test]
        public void CreateEmployee_ReturnsCreatedEmployee()
        {
            //create person
            //then paytype
            //then worker
            Assert.Equals(HttpResponseMessage, )
            //tie worker to paytype
        }
    }
}