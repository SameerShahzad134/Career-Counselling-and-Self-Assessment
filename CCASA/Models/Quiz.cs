namespace CCASA.Models
{
    public class Quiz:AuditableEntity
    {
        public int Id { get; set; }
        public string marks { get; set; }
        public int time { get; set; }
    }
}
