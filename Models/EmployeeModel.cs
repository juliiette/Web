using System;

namespace Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string Detachment { get; set; }
        
        public DateTime DateOfEmployment { get; set; }
        
        public int FirmId { get; set; }
        
        public FirmModel Firm { get; set; }

    }
}