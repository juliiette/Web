using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class FirmEntity : BaseEntity
    {
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public string Department { get; set; }

        public int WorkersQuantity { get; set; }

        public ICollection<EmployeeEntity> Employees { get; set; }

        public ICollection<OfficeEntity> Offices { get; set; }

        [NotMapped]
        public IEnumerable<string> Detachments { get; set; }
    }
}