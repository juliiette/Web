using System;
using System.Collections.Generic;

namespace Models
{
    public class FirmModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public string Department { get; set; }

        public int WorkersQuantity { get; set; }

        public ICollection<EmployeeModel> Employees { get; set; }

        public ICollection<OfficeModel> Offices { get; set; }

        public ICollection<string> Detachments { get; set; }
    }
}