using System;

namespace Data.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string Detachment { get; set; }
        
        public DateTime DateOfEmployment { get; set; }
        
        public int FirmId { get; set; }
        
        public FirmEntity Firm { get; set; }
    }
}