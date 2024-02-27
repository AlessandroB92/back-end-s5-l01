namespace back_end_s5_l01.Models
{

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string TaxCode { get; set; }
        public bool IsMarried { get; set; }
        public int ChildrenCount { get; set; }
        public string Position { get; set; }
    }


}
