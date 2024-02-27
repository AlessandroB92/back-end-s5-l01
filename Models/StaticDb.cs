namespace back_end_s5_l01.Models
{
    public static class StaticDb
    {
        private static int _maxId = 3;
        public static List<Employee> _employee = [
            new Employee()
            {
                EmployeeId = 1,
                FirstName = "Mario",
                LastName = "Rossi",
                Address = "Via Roma 10",
                TaxCode = "RSSMRA80A01H501W",
                IsMarried = true,
                ChildrenCount = 2,
                Position = "Architetto"
            },
            new Employee()
            {
                EmployeeId = 2,
                FirstName = "Luca",
                LastName = "Bianchi",
                Address = "Via Garibaldi 5",
                TaxCode = "BNCLCU85A02F205S",
                IsMarried = false,
                ChildrenCount = 0,
                Position = "Muratore"
            },
            new Employee()
            {
                EmployeeId = 3,
                FirstName = "Giulia",
                LastName = "Ferrari",
                Address = "Corso Italia 15",
                TaxCode = "FRRGLI75M45C345P",
                IsMarried = false,
                ChildrenCount = 1,
                Position = "Segretaria"
            },
            new Employee()
            {
                EmployeeId = 4,
                FirstName = "Anna",
                LastName = "Verdi",
                Address = "Via Dante 20",
                TaxCode = "VRDNNM79C65D123E",
                IsMarried = true,
                ChildrenCount = 3,
                Position = "Idraulico"
            },
            new Employee()
            {
                EmployeeId = 5,
                FirstName = "Giovanni",
                LastName = "Russo",
                Address = "Piazza Duomo 3",
                TaxCode = "RSSGNN82R04L736Q",
                IsMarried = true,
                ChildrenCount = 2,
                Position = "Elettricista"
            },

        ];

        public static Employee Add(string firstName, string lastName, string address, string taxCode, bool isMarried, int childrenCount, string position)
        {
            _maxId++;
            var employee = new Employee()
            {
                EmployeeId = _maxId,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                TaxCode = taxCode,
                IsMarried = isMarried,
                ChildrenCount = childrenCount,
                Position = position,
            };
            _employee.Add(employee);
            return employee;
        }


    }
}
