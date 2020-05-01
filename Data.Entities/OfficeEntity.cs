namespace Data.Entities
{
    public class OfficeEntity : BaseEntity
    {
        public string Name { get; set; }
        
        public int FirmId { get; set; }
        
        public FirmEntity Firm { get; set; }
    }
}