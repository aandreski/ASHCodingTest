namespace ASHCodingTest.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string WorkerType { get; set; }
        public int PersonId { get; set; }
        public int PayTypeId { get; set; }
        public decimal? MaxExpenseAccout { get; set; }
    }
}
