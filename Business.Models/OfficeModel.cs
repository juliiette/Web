namespace Business.Models
{
    public class OfficeModel
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int FirmId { get; set; }
        
        public FirmModel Firm { get; set; }
    }
}